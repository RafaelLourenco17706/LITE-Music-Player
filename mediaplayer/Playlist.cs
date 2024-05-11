using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using System.IO;
using System.Windows.Forms;

namespace mediaplayer
{
    class Playlist
    {
        public static FormMain formMain = FormMain.formMain;

        public static List<string> playlist;
        private static int currentTrackIndex;

        public static void LoadPlaylist()
        {            
            playlist = new List<string>();
            currentTrackIndex = 0;

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.SelectedPath = @"C:\";
            DialogResult result = folderBrowser.ShowDialog();

            if (result == DialogResult.OK)
            {
                string[] mp3Files = Directory.GetFiles(folderBrowser.SelectedPath, "*.mp3");

                if (mp3Files.Length != 0)
                {
                    foreach (string mp3File in mp3Files)
                    {
                        playlist.Add(mp3File);
                    }

                    formMain.userStopped = false;

                    formMain.playlistIsActive = true;
                    formMain.FormUpdate();

                    PlayNext();
                }
                else
                    MessageBox.Show("No MP3 files were found in this folder.", "No MP3 files", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private static void PlayNext()
        {
            if (currentTrackIndex < playlist.Count)
            {
                formMain.waveOutDevice = new WaveOutEvent();
                formMain.audioFileReader = new AudioFileReader(playlist[currentTrackIndex]);
                formMain.waveOutDevice.Init(formMain.audioFileReader);
                formMain.waveOutDevice.Play();

                formMain.waveOutDevice.PlaybackStopped += (sender, e) =>
                {
                    if (!formMain.userStopped)
                    {
                        currentTrackIndex++;
                        PlayNext();
                    } 
                };  
            }
            else
            {
                currentTrackIndex = 0;
            }
        }

        public static void NextSong()
        {
            // This will trigger PlaybackStopped event, effectively skipping the current song and playing the next one.
            formMain.waveOutDevice.Stop();
        }

        public static void PreviousSong()
        {
            // If it is playing the first song in the playlist, it will just go back to the beginning of the song.
            if (currentTrackIndex == 0)
                currentTrackIndex--;
            // Else, go back to previous song.
            else
                currentTrackIndex -= 2;

            // Trigger PlaybackStopped event.
            formMain.waveOutDevice.Stop();
        }

        public static void PlaylistShuffle<T>(List<T> list)
        {
            // Shuffle the playlist using Fisher-Yates shuffle algorithm.

            Random rng = new Random();
            int n = list.Count;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;     
            }

            currentTrackIndex = 0;
            formMain.waveOutDevice.Stop();
        }
    }
}
