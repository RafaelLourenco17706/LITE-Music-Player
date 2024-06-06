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
        private WaveOutEvent waveOutDevice;
        private AudioFileReader audioFileReader;
        private System.Timers.Timer timer;

        private List<string> playlist;
        private int currentTrackIndex;

        private bool userStopped;

        private bool isDragging = false;

        public FormMain()
        {
            InitializeComponent();

            timer = new System.Timers.Timer();
            timer.Interval = 100;
            timer.Elapsed += UpdateSliderPlayback;
            timer.Start();
        }

        #region Form title bar

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

        #endregion

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

                // Suspend layout logic
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
                        btnPlaylist.IconColor = Color.Gray;

                        int seconds = ((int)audioFileReader.TotalTime.TotalSeconds);
                        TimeSpan time = TimeSpan.FromSeconds(seconds);
                        lblTotalTime.Text = time.ToString(@"hh\:mm\:ss");

                        sliderPlayback.Maximum = (int)audioFileReader.TotalTime.TotalSeconds;

                        // Prevent user from accidentally moving the playback slider when selecting file
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

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (waveOutDevice != null)
            {
                waveOutDevice.Dispose();
                audioFileReader.Dispose();
                waveOutDevice = null;
                audioFileReader = null;
                userStopped = true;

                sliderPlayback.Value = 0;
                sliderPlayback.Enabled = false;

                lblCurrentTime.Text = "00:00:00";
                lblTotalTime.Text = "00:00:00";

                btnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
                btnStop.IconColor = Color.Gray;
                btnNext.IconColor = Color.Gray;
                btnPrevious.IconColor = Color.Gray;
                btnShuffle.IconColor = Color.Gray;
                btnPlaylist.IconColor = Color.White;

                lblSong.Text = "";
                lblArtist.Text = "";
                lblFolder.Text = "";
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
            if (btnPlaylist.IconColor == Color.White)
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                    DialogResult dialogResult = folderBrowserDialog.ShowDialog();

                    if (dialogResult == DialogResult.OK)
                    {
                        playlist = new List<string>();
                        currentTrackIndex = 0;

                        string[] extensions = new[] { "*.mp3", "*.wav", "*.aac", "*.flac", "*.m4a", "*.aiff", "*.wma" };
                        string path = folderBrowserDialog.SelectedPath;
                        string folderName = Path.GetFileName(path.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar));

                        string[] files = extensions.SelectMany(ext => Directory.GetFiles(path, ext, SearchOption.TopDirectoryOnly)).OrderBy(file => file).ToArray();

                        if (files.Length != 0)
                        {
                            foreach (string file in files)
                            {
                                playlist.Add(file);
                            }

                            userStopped = false;

                            btnStop.IconColor = Color.White;
                            btnNext.IconColor = Color.White;
                            btnPrevious.IconColor = Color.White;
                            btnShuffle.IconColor = Color.White;
                            btnPlaylist.IconColor = Color.Gray;
                            lblFolder.Text = "Folder: '" + folderName + "'";

                            PlayNext();
                        }
                        else
                            MessageBox.Show("No audio files were found in this folder.", "No audio files", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void PlayNext()
        {
            if (currentTrackIndex < playlist.Count)
            {
                waveOutDevice = new WaveOutEvent();
                audioFileReader = new AudioFileReader(playlist[currentTrackIndex]);
                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();

                ReadMetaData(playlist[currentTrackIndex]);

                if (btnVolume.IconChar == FontAwesome.Sharp.IconChar.VolumeMute)
                    waveOutDevice.Volume = 0f;
                else
                    waveOutDevice.Volume = sliderVolume.Value / 100f;

                waveOutDevice.Play();

                btnPlay.IconChar = FontAwesome.Sharp.IconChar.Pause;
                btnStop.IconColor = Color.White;
                btnPlaylist.IconColor = Color.Gray;

                int seconds = ((int)audioFileReader.TotalTime.TotalSeconds);
                TimeSpan time = TimeSpan.FromSeconds(seconds);
                lblTotalTime.Text = time.ToString(@"hh\:mm\:ss");

                sliderPlayback.Maximum = (int)audioFileReader.TotalTime.TotalSeconds;
                sliderPlayback.Enabled = true;

                waveOutDevice.PlaybackStopped += (sender, e) =>
                {
                    if (userStopped == false)
                    {
                        currentTrackIndex++;
                        PlayNext();
                    }
                };
            }
            else
            {
                waveOutDevice.Dispose();
                audioFileReader.Dispose();
                waveOutDevice = null;
                audioFileReader = null;
                userStopped = true;

                sliderPlayback.Value = 0;
                sliderPlayback.Enabled = false;

                lblCurrentTime.Text = "00:00:00";
                lblTotalTime.Text = "00:00:00";

                btnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
                btnStop.IconColor = Color.Gray;
                btnNext.IconColor = Color.Gray;
                btnPrevious.IconColor = Color.Gray;
                btnShuffle.IconColor = Color.Gray;
                btnPlaylist.IconColor = Color.White;

                lblSong.Text = "";
                lblArtist.Text = "";
                lblFolder.Text = "";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (btnNext.IconColor == Color.White)
            {
                // This will trigger PlaybackStopped event, effectively skipping the current song and playing the next one.
                waveOutDevice.Stop();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (btnPrevious.IconColor == Color.White)
            {
                // If it is playing the first song in the playlist, it will just go back to the beginning of the song.
                if (currentTrackIndex == 0)
                    currentTrackIndex--;
                // Else, go back to previous song.
                else
                    currentTrackIndex -= 2;

                // Trigger PlaybackStopped event.
                waveOutDevice.Stop();
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            if (btnShuffle.IconColor == Color.White)
            {
                if (lblFolder.Text.Contains("(shuffled)") == false)
                    lblFolder.Text += " (shuffled)";

                // Shuffle the playlist using Fisher-Yates shuffle algorithm.

                Random rng = new Random();
                int n = playlist.Count;

                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    string value = playlist[k];
                    playlist[k] = playlist[n];
                    playlist[n] = value;
                }

                currentTrackIndex = -1;
                waveOutDevice.Stop();
            }
        }

        #endregion

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