using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LITE_Music_Player
{
    public class Slider : TrackBar
    {
        private int minimum = 0;
        private int maximum = 100;
        private int value = 0;
        private int thumbSize = 15;

        public new event EventHandler ValueChanged;

        public new int Minimum
        {
            get { return minimum; }
            set { minimum = value; Invalidate(); }
        }

        public new int Maximum
        {
            get { return maximum; }
            set { maximum = value; Invalidate(); }
        }

        public new int Value
        {
            get { return this.value; }
            set
            {
                if (this.value != value)
                {
                    this.value = value;
                    Invalidate();
                    ValueChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public Slider()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.Size = new Size(300, 30);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawTrackBar(e.Graphics);
        }

        private void DrawTrackBar(Graphics g)
        {
            int trackHeight = 4;
            int trackY = (Height - trackHeight) / 2;
            Rectangle trackRect = new Rectangle(0, trackY, Width, trackHeight);

            float range = maximum - minimum;
            float relativeValue = (float)(value - minimum) / range;
            int thumbX = (int)(relativeValue * (Width - thumbSize));

            // Draw the completed portion of the track
            Rectangle completedRect = new Rectangle(0, trackY, thumbX + thumbSize / 2, trackHeight);
            using (Brush completedBrush = new SolidBrush(Color.FromArgb(0, 60, 100)))
            {
                g.FillRectangle(completedBrush, completedRect);
            }

            // Draw the remaining portion of the track
            Rectangle remainingRect = new Rectangle(thumbX + thumbSize / 2, trackY, Width - (thumbX + thumbSize / 2), trackHeight);
            using (Brush remainingBrush = new SolidBrush(Color.LightGray))
            {
                g.FillRectangle(remainingBrush, remainingRect);
            }

            // Draw the thumb
            using (Brush thumbBrush = new SolidBrush(Color.FromArgb(0, 100, 200)))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.FillEllipse(thumbBrush, thumbX, ((Height - thumbSize) / 2) - 1, thumbSize, thumbSize);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            UpdateValueFromMouse(e.X);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                UpdateValueFromMouse(e.X);
            }
        }

        private void UpdateValueFromMouse(int mouseX)
        {
            mouseX = Math.Max(0, Math.Min(mouseX, Width - thumbSize));
            float range = maximum - minimum;
            float relativePosition = (float)mouseX / (Width - thumbSize);
            Value = (int)(relativePosition * range) + minimum;
        }
    }
}
