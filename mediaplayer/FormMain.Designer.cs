
namespace mediaplayer
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPause = new System.Windows.Forms.Button();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.btnPlaylist = new FontAwesome.Sharp.IconPictureBox();
            this.btnShuffle = new FontAwesome.Sharp.IconPictureBox();
            this.btnStop = new FontAwesome.Sharp.IconPictureBox();
            this.btnPrevious = new FontAwesome.Sharp.IconPictureBox();
            this.btnPlay = new FontAwesome.Sharp.IconPictureBox();
            this.btnNext = new FontAwesome.Sharp.IconPictureBox();
            this.iconVolume = new FontAwesome.Sharp.IconPictureBox();
            this.sliderVolume = new mediaplayer.Slider();
            this.sliderPlayback = new mediaplayer.Slider();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderPlayback)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(670, 12);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(100, 50);
            this.btnPause.TabIndex = 1;
            this.btnPause.TabStop = false;
            this.btnPause.Text = "pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCurrentTime.Location = new System.Drawing.Point(30, 435);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(64, 17);
            this.lblCurrentTime.TabIndex = 8;
            this.lblCurrentTime.Text = "00:00:00";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalTime.Location = new System.Drawing.Point(690, 435);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(64, 17);
            this.lblTotalTime.TabIndex = 9;
            this.lblTotalTime.Text = "00:00:00";
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.ForeColor = System.Drawing.Color.Gray;
            this.btnPlaylist.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnPlaylist.IconColor = System.Drawing.Color.Gray;
            this.btnPlaylist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlaylist.IconSize = 50;
            this.btnPlaylist.Location = new System.Drawing.Point(498, 295);
            this.btnPlaylist.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(50, 50);
            this.btnPlaylist.TabIndex = 23;
            this.btnPlaylist.TabStop = false;
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.Transparent;
            this.btnShuffle.ForeColor = System.Drawing.Color.Gray;
            this.btnShuffle.IconChar = FontAwesome.Sharp.IconChar.Random;
            this.btnShuffle.IconColor = System.Drawing.Color.Gray;
            this.btnShuffle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShuffle.IconSize = 40;
            this.btnShuffle.Location = new System.Drawing.Point(567, 305);
            this.btnShuffle.Margin = new System.Windows.Forms.Padding(0);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(40, 40);
            this.btnShuffle.TabIndex = 22;
            this.btnShuffle.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.ForeColor = System.Drawing.Color.Gray;
            this.btnStop.IconChar = FontAwesome.Sharp.IconChar.Stop;
            this.btnStop.IconColor = System.Drawing.Color.Gray;
            this.btnStop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStop.IconSize = 50;
            this.btnStop.Location = new System.Drawing.Point(242, 480);
            this.btnStop.Margin = new System.Windows.Forms.Padding(0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(50, 50);
            this.btnStop.TabIndex = 21;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.ForeColor = System.Drawing.Color.Gray;
            this.btnPrevious.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            this.btnPrevious.IconColor = System.Drawing.Color.Gray;
            this.btnPrevious.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrevious.IconSize = 50;
            this.btnPrevious.Location = new System.Drawing.Point(567, 234);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(50, 50);
            this.btnPrevious.TabIndex = 20;
            this.btnPrevious.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnPlay.IconColor = System.Drawing.Color.White;
            this.btnPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlay.IconSize = 50;
            this.btnPlay.Location = new System.Drawing.Point(369, 480);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(50, 50);
            this.btnPlay.TabIndex = 18;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.ForeColor = System.Drawing.Color.Gray;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.ForwardStep;
            this.btnNext.IconColor = System.Drawing.Color.Gray;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.IconSize = 50;
            this.btnNext.Location = new System.Drawing.Point(670, 234);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 50);
            this.btnNext.TabIndex = 19;
            this.btnNext.TabStop = false;
            // 
            // iconVolume
            // 
            this.iconVolume.BackColor = System.Drawing.Color.Transparent;
            this.iconVolume.IconChar = FontAwesome.Sharp.IconChar.VolumeHigh;
            this.iconVolume.IconColor = System.Drawing.Color.White;
            this.iconVolume.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconVolume.IconSize = 40;
            this.iconVolume.Location = new System.Drawing.Point(603, 485);
            this.iconVolume.Margin = new System.Windows.Forms.Padding(0);
            this.iconVolume.Name = "iconVolume";
            this.iconVolume.Size = new System.Drawing.Size(40, 40);
            this.iconVolume.TabIndex = 17;
            this.iconVolume.TabStop = false;
            // 
            // sliderVolume
            // 
            this.sliderVolume.LargeChange = 0;
            this.sliderVolume.Location = new System.Drawing.Point(652, 474);
            this.sliderVolume.Maximum = 100;
            this.sliderVolume.Name = "sliderVolume";
            this.sliderVolume.Size = new System.Drawing.Size(102, 56);
            this.sliderVolume.SmallChange = 0;
            this.sliderVolume.TabIndex = 24;
            this.sliderVolume.TickFrequency = 0;
            this.sliderVolume.Value = 100;
            this.sliderVolume.ValueChanged += new System.EventHandler(this.sliderVolume_ValueChanged);
            // 
            // sliderPlayback
            // 
            this.sliderPlayback.Enabled = false;
            this.sliderPlayback.LargeChange = 0;
            this.sliderPlayback.Location = new System.Drawing.Point(21, 383);
            this.sliderPlayback.Maximum = 100;
            this.sliderPlayback.Name = "sliderPlayback";
            this.sliderPlayback.Size = new System.Drawing.Size(733, 56);
            this.sliderPlayback.SmallChange = 0;
            this.sliderPlayback.TabIndex = 10;
            this.sliderPlayback.TickFrequency = 0;
            this.sliderPlayback.MouseDown += new System.Windows.Forms.MouseEventHandler(this.slider_MouseDown);
            this.sliderPlayback.MouseUp += new System.Windows.Forms.MouseEventHandler(this.slider_MouseUp);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.sliderVolume);
            this.Controls.Add(this.btnPlaylist);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.iconVolume);
            this.Controls.Add(this.sliderPlayback);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.btnPause);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Player";
            ((System.ComponentModel.ISupportInitialize)(this.btnPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderPlayback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblTotalTime;
        private Slider sliderPlayback;
        private FontAwesome.Sharp.IconPictureBox btnPlaylist;
        private FontAwesome.Sharp.IconPictureBox btnShuffle;
        private FontAwesome.Sharp.IconPictureBox btnStop;
        private FontAwesome.Sharp.IconPictureBox btnPrevious;
        private FontAwesome.Sharp.IconPictureBox btnPlay;
        private FontAwesome.Sharp.IconPictureBox btnNext;
        private FontAwesome.Sharp.IconPictureBox iconVolume;
        private Slider sliderVolume;
    }
}

