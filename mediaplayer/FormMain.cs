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
        private WaveOutEvent waveOutDevice;
        private AudioFileReader audioFileReader;

        public FormMain()
        {
            InitializeComponent();
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
                waveOutDevice = null;
            }
        }
    }
}
