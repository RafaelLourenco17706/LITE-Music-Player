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
        private readonly System.Timers.Timer timer;

        public static bool playlistIsActive;
        public static bool userStopped;

        private bool isDragging = false;

        public FormMain()
        {
            InitializeComponent();

            timer = new System.Timers.Timer();
            timer.Interval = 100;
            timer.Elapsed += UpdateSliderPlayback;
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

        #region Sliders

        private void sliderVolume_ValueChanged(object sender, EventArgs e)
        {
            if (waveOutDevice != null)
                waveOutDevice.Volume = sliderVolume.Value / 100f;

            if (sliderVolume.Value == 0)
                iconVolume.IconChar = FontAwesome.Sharp.IconChar.VolumeMute;
            else
                iconVolume.IconChar = FontAwesome.Sharp.IconChar.VolumeHigh;
        }

        private void UpdateSliderPlayback(object sender, ElapsedEventArgs e)
        {
            if (waveOutDevice?.PlaybackState == PlaybackState.Playing)
            {
                if (isDragging == false)
                    try { Invoke(new Action(() => sliderPlayback.Value = (int)audioFileReader.CurrentTime.TotalSeconds)); } catch { }
            }

            if (waveOutDevice?.PlaybackState == PlaybackState.Playing || waveOutDevice?.PlaybackState == PlaybackState.Paused)
            {
                int seconds = ((int)audioFileReader.CurrentTime.TotalSeconds);
                TimeSpan time = TimeSpan.FromSeconds(seconds);

                try { Invoke(new Action(() => lblCurrentTime.Text = time.ToString(@"hh\:mm\:ss"))); } catch { }
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
                audioFileReader.CurrentTime = TimeSpan.FromSeconds(sliderPlayback.Value);
            }
        }

        #endregion

        #region Buttons

        private async void btnPlay_Click(object sender, EventArgs e)
        {
            if (waveOutDevice == null)
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                    openFileDialog.Filter = "Audio Files (*.mp3;*.wav;*.aac;*.flac;*.m4a;*.aiff;*.wma) | *.mp3;*.wav;*.aac;*.flac;*.m4a;*.aiff;*.wma";
                    openFileDialog.ShowDialog();

                    if (openFileDialog.FileName != "")
                    {
                        waveOutDevice = new WaveOutEvent();
                        audioFileReader = new AudioFileReader(openFileDialog.FileName);
                        waveOutDevice.Init(audioFileReader);
                        waveOutDevice.Volume = sliderVolume.Value / 100f;
                        waveOutDevice.Play();
                        waveOutDevice.PlaybackStopped += btnStop_Click;

                        btnPlay.IconChar = FontAwesome.Sharp.IconChar.Pause;

                        int seconds = ((int)audioFileReader.TotalTime.TotalSeconds);
                        TimeSpan time = TimeSpan.FromSeconds(seconds);
                        lblTotalTime.Text = time.ToString(@"hh\:mm\:ss");

                        sliderPlayback.Maximum = (int)audioFileReader.TotalTime.TotalSeconds;

                        // Prevent user from accidentally moving the slider when selecting file
                        await Task.Delay(100);

                        sliderPlayback.Enabled = true;  
                    }
                }  
            }
            else
            {
                if (waveOutDevice.PlaybackState == PlaybackState.Playing)
                {
                    waveOutDevice.Pause();
                    btnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
                }
                else if (waveOutDevice.PlaybackState == PlaybackState.Paused)
                {
                    waveOutDevice.Play();
                    btnPlay.IconChar = FontAwesome.Sharp.IconChar.Pause;
                }
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            
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
                sliderPlayback.Value = 0;
                sliderPlayback.Enabled = false;

                btnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
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