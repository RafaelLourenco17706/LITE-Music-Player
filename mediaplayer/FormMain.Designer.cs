
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.tlpBottom = new System.Windows.Forms.TableLayoutPanel();
            this.btnShuffle = new FontAwesome.Sharp.IconPictureBox();
            this.btnStop = new FontAwesome.Sharp.IconPictureBox();
            this.btnPrevious = new FontAwesome.Sharp.IconPictureBox();
            this.btnPlay = new FontAwesome.Sharp.IconPictureBox();
            this.sliderPlayback = new mediaplayer.Slider();
            this.btnNext = new FontAwesome.Sharp.IconPictureBox();
            this.btnPlaylist = new FontAwesome.Sharp.IconPictureBox();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.sliderVolume = new mediaplayer.Slider();
            this.btnVolume = new FontAwesome.Sharp.IconPictureBox();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.tlpTop = new System.Windows.Forms.TableLayoutPanel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconLogo = new FontAwesome.Sharp.IconPictureBox();
            this.lblSong = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.tlpBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderPlayback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolume)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.tlpTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pnlBottom, 0, 2);
            this.tlpMain.Controls.Add(this.pnlTop, 0, 0);
            this.tlpMain.Controls.Add(this.panel1, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.5F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.tlpMain.Size = new System.Drawing.Size(800, 600);
            this.tlpMain.TabIndex = 25;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlBottom.Controls.Add(this.tlpBottom);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 503);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(800, 97);
            this.pnlBottom.TabIndex = 32;
            // 
            // tlpBottom
            // 
            this.tlpBottom.ColumnCount = 8;
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.685308F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.685308F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.93508F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.370355F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.078051F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.370355F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.93508F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.94046F));
            this.tlpBottom.Controls.Add(this.btnShuffle, 1, 2);
            this.tlpBottom.Controls.Add(this.btnStop, 2, 2);
            this.tlpBottom.Controls.Add(this.btnPrevious, 3, 2);
            this.tlpBottom.Controls.Add(this.btnPlay, 4, 2);
            this.tlpBottom.Controls.Add(this.sliderPlayback, 0, 0);
            this.tlpBottom.Controls.Add(this.btnNext, 5, 2);
            this.tlpBottom.Controls.Add(this.btnPlaylist, 0, 2);
            this.tlpBottom.Controls.Add(this.lblCurrentTime, 0, 1);
            this.tlpBottom.Controls.Add(this.sliderVolume, 7, 2);
            this.tlpBottom.Controls.Add(this.btnVolume, 6, 2);
            this.tlpBottom.Controls.Add(this.lblTotalTime, 7, 1);
            this.tlpBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBottom.Location = new System.Drawing.Point(0, 0);
            this.tlpBottom.Name = "tlpBottom";
            this.tlpBottom.RowCount = 3;
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.36642F));
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.04798F));
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.58561F));
            this.tlpBottom.Size = new System.Drawing.Size(800, 97);
            this.tlpBottom.TabIndex = 0;
            this.tlpBottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tlpBottom_MouseDown);
            this.tlpBottom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlpBottom_MouseMove);
            this.tlpBottom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tlpBottom_MouseUp);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnShuffle.BackColor = System.Drawing.Color.Transparent;
            this.btnShuffle.ForeColor = System.Drawing.Color.Gray;
            this.btnShuffle.IconChar = FontAwesome.Sharp.IconChar.Random;
            this.btnShuffle.IconColor = System.Drawing.Color.Gray;
            this.btnShuffle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShuffle.IconSize = 36;
            this.btnShuffle.Location = new System.Drawing.Point(87, 59);
            this.btnShuffle.Margin = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(40, 36);
            this.btnShuffle.TabIndex = 32;
            this.btnShuffle.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.ForeColor = System.Drawing.Color.Gray;
            this.btnStop.IconChar = FontAwesome.Sharp.IconChar.Stop;
            this.btnStop.IconColor = System.Drawing.Color.Gray;
            this.btnStop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStop.IconSize = 38;
            this.btnStop.Location = new System.Drawing.Point(259, 54);
            this.btnStop.Margin = new System.Windows.Forms.Padding(0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(38, 41);
            this.btnStop.TabIndex = 21;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.ForeColor = System.Drawing.Color.Gray;
            this.btnPrevious.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            this.btnPrevious.IconColor = System.Drawing.Color.Gray;
            this.btnPrevious.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrevious.IconSize = 38;
            this.btnPrevious.Location = new System.Drawing.Point(333, 54);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(38, 41);
            this.btnPrevious.TabIndex = 31;
            this.btnPrevious.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnPlay.IconColor = System.Drawing.Color.White;
            this.btnPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlay.IconSize = 38;
            this.btnPlay.Location = new System.Drawing.Point(384, 54);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(38, 41);
            this.btnPlay.TabIndex = 18;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // sliderPlayback
            // 
            this.sliderPlayback.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBottom.SetColumnSpan(this.sliderPlayback, 8);
            this.sliderPlayback.Enabled = false;
            this.sliderPlayback.LargeChange = 0;
            this.sliderPlayback.Location = new System.Drawing.Point(20, 5);
            this.sliderPlayback.Margin = new System.Windows.Forms.Padding(20, 5, 20, 0);
            this.sliderPlayback.Maximum = 100;
            this.sliderPlayback.Name = "sliderPlayback";
            this.sliderPlayback.Size = new System.Drawing.Size(760, 31);
            this.sliderPlayback.SmallChange = 0;
            this.sliderPlayback.TabIndex = 10;
            this.sliderPlayback.TickFrequency = 0;
            this.sliderPlayback.MouseDown += new System.Windows.Forms.MouseEventHandler(this.slider_MouseDown);
            this.sliderPlayback.MouseUp += new System.Windows.Forms.MouseEventHandler(this.slider_MouseUp);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.ForeColor = System.Drawing.Color.Gray;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.ForwardStep;
            this.btnNext.IconColor = System.Drawing.Color.Gray;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.IconSize = 38;
            this.btnNext.Location = new System.Drawing.Point(435, 54);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(38, 41);
            this.btnNext.TabIndex = 29;
            this.btnNext.TabStop = false;
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.ForeColor = System.Drawing.Color.Gray;
            this.btnPlaylist.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnPlaylist.IconColor = System.Drawing.Color.Gray;
            this.btnPlaylist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlaylist.IconSize = 40;
            this.btnPlaylist.Location = new System.Drawing.Point(37, 55);
            this.btnPlaylist.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(40, 40);
            this.btnPlaylist.TabIndex = 30;
            this.btnPlaylist.TabStop = false;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.tlpBottom.SetColumnSpan(this.lblCurrentTime, 2);
            this.lblCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCurrentTime.Location = new System.Drawing.Point(20, 36);
            this.lblCurrentTime.Margin = new System.Windows.Forms.Padding(20, 0, 2, 0);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(56, 16);
            this.lblCurrentTime.TabIndex = 8;
            this.lblCurrentTime.Text = "00:00:00";
            // 
            // sliderVolume
            // 
            this.sliderVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sliderVolume.LargeChange = 0;
            this.sliderVolume.Location = new System.Drawing.Point(667, 53);
            this.sliderVolume.Margin = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.sliderVolume.Maximum = 100;
            this.sliderVolume.Name = "sliderVolume";
            this.sliderVolume.Size = new System.Drawing.Size(113, 44);
            this.sliderVolume.SmallChange = 0;
            this.sliderVolume.TabIndex = 24;
            this.sliderVolume.TickFrequency = 0;
            this.sliderVolume.Value = 100;
            this.sliderVolume.ValueChanged += new System.EventHandler(this.sliderVolume_ValueChanged);
            // 
            // btnVolume
            // 
            this.btnVolume.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnVolume.BackColor = System.Drawing.Color.Transparent;
            this.btnVolume.IconChar = FontAwesome.Sharp.IconChar.VolumeHigh;
            this.btnVolume.IconColor = System.Drawing.Color.White;
            this.btnVolume.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVolume.IconSize = 30;
            this.btnVolume.Location = new System.Drawing.Point(622, 61);
            this.btnVolume.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(30, 32);
            this.btnVolume.TabIndex = 17;
            this.btnVolume.TabStop = false;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalTime.Location = new System.Drawing.Point(727, 36);
            this.lblTotalTime.Margin = new System.Windows.Forms.Padding(2, 0, 17, 0);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(56, 16);
            this.lblTotalTime.TabIndex = 9;
            this.lblTotalTime.Text = "00:00:00";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pnlTop.Controls.Add(this.tlpTop);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 50);
            this.pnlTop.TabIndex = 34;
            // 
            // tlpTop
            // 
            this.tlpTop.ColumnCount = 4;
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpTop.Controls.Add(this.lblAppName, 0, 0);
            this.tlpTop.Controls.Add(this.btnMaximize, 2, 0);
            this.tlpTop.Controls.Add(this.btnMinimize, 1, 0);
            this.tlpTop.Controls.Add(this.btnClose, 3, 0);
            this.tlpTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTop.Location = new System.Drawing.Point(0, 0);
            this.tlpTop.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTop.Name = "tlpTop";
            this.tlpTop.RowCount = 1;
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTop.Size = new System.Drawing.Size(800, 50);
            this.tlpTop.TabIndex = 1;
            this.tlpTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tlpTop_MouseDown);
            this.tlpTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlpTop_MouseMove);
            this.tlpTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tlpTop_MouseUp);
            // 
            // lblAppName
            // 
            this.lblAppName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(20, 15);
            this.lblAppName.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(135, 20);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "LITE Music Player";
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 30;
            this.btnMaximize.Location = new System.Drawing.Point(710, 12);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 30;
            this.btnMinimize.Location = new System.Drawing.Point(660, 12);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 30;
            this.btnClose.Location = new System.Drawing.Point(760, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblArtist);
            this.panel1.Controls.Add(this.lblSong);
            this.panel1.Controls.Add(this.iconLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 447);
            this.panel1.TabIndex = 35;
            // 
            // iconLogo
            // 
            this.iconLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.iconLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.iconLogo.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.iconLogo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.iconLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLogo.IconSize = 447;
            this.iconLogo.Location = new System.Drawing.Point(0, 0);
            this.iconLogo.Margin = new System.Windows.Forms.Padding(0);
            this.iconLogo.Name = "iconLogo";
            this.iconLogo.Size = new System.Drawing.Size(794, 447);
            this.iconLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconLogo.TabIndex = 34;
            this.iconLogo.TabStop = false;
            // 
            // lblSong
            // 
            this.lblSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSong.AutoSize = true;
            this.lblSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSong.ForeColor = System.Drawing.Color.DimGray;
            this.lblSong.Location = new System.Drawing.Point(13, 392);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(0, 24);
            this.lblSong.TabIndex = 35;
            // 
            // lblArtist
            // 
            this.lblArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.ForeColor = System.Drawing.Color.DimGray;
            this.lblArtist.Location = new System.Drawing.Point(14, 417);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(0, 16);
            this.lblArtist.TabIndex = 36;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LITE Music Player";
            this.tlpMain.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.tlpBottom.ResumeLayout(false);
            this.tlpBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderPlayback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolume)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.tlpTop.ResumeLayout(false);
            this.tlpTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TableLayoutPanel tlpBottom;
        private FontAwesome.Sharp.IconPictureBox btnPlay;
        private FontAwesome.Sharp.IconPictureBox btnVolume;
        private FontAwesome.Sharp.IconPictureBox btnStop;
        private System.Windows.Forms.Label lblTotalTime;
        private Slider sliderVolume;
        private Slider sliderPlayback;
        private System.Windows.Forms.Label lblCurrentTime;
        private FontAwesome.Sharp.IconPictureBox btnNext;
        private FontAwesome.Sharp.IconPictureBox btnPlaylist;
        private FontAwesome.Sharp.IconPictureBox btnPrevious;
        private FontAwesome.Sharp.IconPictureBox btnShuffle;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TableLayoutPanel tlpTop;
        private System.Windows.Forms.Label lblAppName;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblSong;
        private FontAwesome.Sharp.IconPictureBox iconLogo;
    }
}

