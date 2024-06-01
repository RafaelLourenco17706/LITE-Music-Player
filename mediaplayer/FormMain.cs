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
using System.Timers;

namespace mediaplayer
{
    public partial class FormMain : Form
    {
        public static WaveOutEvent waveOutDevice;
        public static AudioFileReader audioFileReader;
        private System.Timers.Timer timer;

        public static bool playlistIsActive;
        public static bool userStopped;

        private bool isDragging = false;

        public FormMain()
        {
            InitializeComponent();

            timer = new System.Timers.Timer();
            timer.Interval = 100;
            timer.Elapsed += UpdateSlider;
            timer.Start();
        }

        public void FormUpdate()
        {
            if (playlistIsActive)
            {
                btnNext.Visible = true;
                btnPrevious.Visible = true;
                btnShuffle.Visible = true;
            }
            else
            {
                btnNext.Visible = false;
                btnPrevious.Visible = false;
                btnShuffle.Visible = false;
            }
        }

        #region slider

        private void UpdateSlider(object sender, ElapsedEventArgs e)
        {
            if (waveOutDevice?.PlaybackState == PlaybackState.Playing)
            {
                if (isDragging == false)
                    Invoke(new Action(() => slider.Value = (int)audioFileReader.CurrentTime.TotalSeconds));
            }

            if (waveOutDevice?.PlaybackState == PlaybackState.Playing || waveOutDevice?.PlaybackState == PlaybackState.Paused)
            {
                int seconds = ((int)audioFileReader.CurrentTime.TotalSeconds);
                TimeSpan time = TimeSpan.FromSeconds(seconds);

                Invoke(new Action(() => lblCurrentTime.Text = time.ToString(@"hh\:mm\:ss")));
            }
        }

        private void slider_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
        }

        private void slider_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            if (audioFileReader != null)
            {
                audioFileReader.CurrentTime = TimeSpan.FromSeconds(slider.Value);
            }
        }

        #endregion

        #region Buttons

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (waveOutDevice == null)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                openFileDialog.Filter = "mp3 files (*.mp3)|*.mp3";
                openFileDialog.ShowDialog();

                if (openFileDialog.FileName != "")
                {
                    waveOutDevice = new WaveOutEvent();
                    audioFileReader = new AudioFileReader(openFileDialog.FileName);
                    waveOutDevice.Init(audioFileReader);
                    waveOutDevice.Play();
                    waveOutDevice.PlaybackStopped += btnStop_Click;

                    slider.Maximum = (int)audioFileReader.TotalTime.TotalSeconds;

                    int seconds = ((int)audioFileReader.TotalTime.TotalSeconds);
                    TimeSpan time = TimeSpan.FromSeconds(seconds);
                    lblTotalTime.Text = time.ToString(@"hh\:mm\:ss");

                    slider.Enabled = true;
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

                lblCurrentTime.Text = "00:00:00";
                lblTotalTime.Text = "00:00:00";
                slider.Value = 0;
                slider.Enabled = false;
            }
        }

        #endregion

        #region Playlist

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            if (waveOutDevice == null)
                Playlist.LoadPlaylist();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (playlistIsActive)
                Playlist.NextSong();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (playlistIsActive)
                Playlist.PreviousSong();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            if (playlistIsActive)
                Playlist.PlaylistShuffle(Playlist.playlist);
        }

        #endregion

    }
}