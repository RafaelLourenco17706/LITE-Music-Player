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
using TagLib;

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

        #region Form drag and resize

        private bool dragging = false;
        private Point dragStartPoint;

        private bool resizing = false;
        private Point resizeStartPoint;
        private Size resizeStartSize;
        private const int resizeBorderWidth = 10;

        private void tlpTop_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragStartPoint = new Point(e.X, e.Y);
        }

        private void tlpTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point point = PointToScreen(new Point(e.X, e.Y));
                Location = new Point(point.X - dragStartPoint.X, point.Y - dragStartPoint.Y);
            }
        }

        private void tlpTop_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void tlpBottom_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsInResizeZone(e.Location, tlpBottom))
            {
                resizing = true;
                resizeStartPoint = e.Location;
                resizeStartSize = this.Size;

                this.SuspendLayout();
            }
        }

        private void tlpBottom_MouseMove(object sender, MouseEventArgs e)
        {
            if (resizing)
            {
                int newWidth = resizeStartSize.Width + (e.X - resizeStartPoint.X);
                int newHeight = resizeStartSize.Height + (e.Y - resizeStartPoint.Y);
                this.Size = new Size(newWidth, newHeight);
            }
            else
            {
                if (IsInResizeZone(e.Location, tlpBottom))
                {
                    this.Cursor = Cursors.SizeNWSE; // Set the cursor to indicate resizing
                }
                else
                {
                    this.Cursor = Cursors.Default; // Set the cursor to default
                }
            }
        }

        private void tlpBottom_MouseUp(object sender, MouseEventArgs e)
        {
            if (resizing)
            {
                resizing = false;
                this.Cursor = Cursors.Default;

                // Resume layout logic after resizing is completed
                this.ResumeLayout();
            }
        }

        private bool IsInResizeZone(Point point, Control control)
        {
            return point.X >= control.ClientSize.Width - resizeBorderWidth && point.Y >= control.ClientSize.Height - resizeBorderWidth;
        }

        #endregion

        #region Sliders

        private void sliderVolume_ValueChanged(object sender, EventArgs e)
        {
            if (waveOutDevice != null)
                waveOutDevice.Volume = sliderVolume.Value / 100f;

            if (sliderVolume.Value == 0)
                btnVolume.IconChar = FontAwesome.Sharp.IconChar.VolumeMute;
            else
                btnVolume.IconChar = FontAwesome.Sharp.IconChar.VolumeHigh;
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

                        ReadMetaData(openFileDialog.FileName);

                        if (btnVolume.IconChar == FontAwesome.Sharp.IconChar.VolumeMute)
                            waveOutDevice.Volume = 0f;
                        else
                            waveOutDevice.Volume = sliderVolume.Value / 100f;

                        waveOutDevice.Play();
                        waveOutDevice.PlaybackStopped += btnStop_Click;

                        btnPlay.IconChar = FontAwesome.Sharp.IconChar.Pause;
                        btnStop.IconColor = Color.White;

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
                btnStop.IconColor = Color.Gray;
            }
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            if (sliderVolume.Value != 0)
            {
                if (btnVolume.IconChar == FontAwesome.Sharp.IconChar.VolumeMute)
                    btnVolume.IconChar = FontAwesome.Sharp.IconChar.VolumeHigh;
                else
                    btnVolume.IconChar = FontAwesome.Sharp.IconChar.VolumeMute;
            }

            if (waveOutDevice != null)
            {
                if (btnVolume.IconChar == FontAwesome.Sharp.IconChar.VolumeMute)
                    waveOutDevice.Volume = 0f;
                else
                    waveOutDevice.Volume = sliderVolume.Value / 100f;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ReadMetaData(string filepath)
        {
            using (var file = TagLib.File.Create(filepath))
            {
                lblSong.Text = string.IsNullOrEmpty(file.Tag.Title) ? "Unknown song" : file.Tag.Title;

                if (lblSong.Text == "Unknown song")
                    lblSong.ForeColor = Color.DimGray;
                else
                    lblSong.ForeColor = Color.White;

                lblArtist.Text = file.Tag.Performers.Length > 0 ? file.Tag.Performers[0] : "Unknown artist";
                lblArtist.Text = lblArtist.Text.Replace("/", ", ");

                if (lblArtist.Text == "Unknown artist")
                    lblArtist.ForeColor = Color.DimGray;
                else
                    lblArtist.ForeColor = Color.White;
            }
            
        }

    }
}