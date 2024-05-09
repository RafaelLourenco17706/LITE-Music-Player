using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using System.IO;

namespace mediaplayer
{
    public partial class FormMain : Form
    {
        public static FormMain formMain;

        public WaveOutEvent waveOutDevice;
        public AudioFileReader audioFileReader;

        public bool playlistIsActive;
        public bool userStopped;

        public FormMain()
        {
            InitializeComponent();
            formMain = this;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (waveOutDevice == null)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "mp3 files (*.mp3)|*.mp3";
                openFileDialog.ShowDialog();

                if (openFileDialog.FileName != "")
                {
                    waveOutDevice = new WaveOutEvent();
                    audioFileReader = new AudioFileReader(openFileDialog.FileName);
                    waveOutDevice.Init(audioFileReader);
                    waveOutDevice.Play();
                }
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (waveOutDevice != null)
            {
                if (waveOutDevice.PlaybackState == PlaybackState.Playing)
                {
                    waveOutDevice.Pause();
                }
                else if (waveOutDevice.PlaybackState == PlaybackState.Paused)
                {
                    waveOutDevice.Play();
                }
            }
        } 

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (waveOutDevice != null)
            {
                waveOutDevice.Dispose();
                audioFileReader.Dispose();
                waveOutDevice = null;
                audioFileReader = null;
       
                playlistIsActive = false;
                userStopped = true;

                FormUpdate();
            }
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            if (waveOutDevice == null)
                Playlist.LoadPlaylist();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Playlist.NextSong();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Playlist.PreviousSong();
        }
       
        public void FormUpdate()
        {
            if (playlistIsActive)
            {
                btnNext.Visible = true;
                btnPrevious.Visible = true;
            }
            else
            {
                btnNext.Visible = false;
                btnPrevious.Visible = false;
            }
        }
    }
}