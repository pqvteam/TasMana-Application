using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIs.CustomComponent
{
    public class CustomPanel : Panel
    {
        private Color _borderColor = Color.Black;
        private int _borderWidth = 1;
        private int _borderRadius = 0;
        private Color _backgroundColor = Color.Transparent;
        private Color _gradientStartColor = Color.White;
        private Color _gradientEndColor = Color.White;
        private float _gradientAngle = 0f;

        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }

        public int BorderWidth
        {
            get { return _borderWidth; }
            set
            {
                _borderWidth = value;
                this.Invalidate();
            }
        }

        public int BorderRadius
        {
            get { return _borderRadius; }
            set
            {
                _borderRadius = value;
                this.Invalidate();
            }
        }

        public Color BackgroundColor
        {
            get { return _backgroundColor; }
            set
            {
                _backgroundColor = value;
                this.Invalidate();
            }
        }

        public Color GradientStartColor
        {
            get { return _gradientStartColor; }
            set
            {
                _gradientStartColor = value;
                this.Invalidate();
            }
        }

        public Color GradientEndColor
        {
            get { return _gradientEndColor; }
            set
            {
                _gradientEndColor = value;
                this.Invalidate();
            }
        }

        public float GradientAngle
        {
            get { return _gradientAngle; }
            set
            {
                _gradientAngle = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Vẽ gradient background nếu được chỉ định
            if (_gradientStartColor != _gradientEndColor)
            {
                using (LinearGradientBrush gradientBrush = new LinearGradientBrush(this.ClientRectangle, _gradientStartColor, _gradientEndColor, _gradientAngle))
                {
                    e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);
                }
            }
            else
            {
                // Vẽ màu nền thường nếu không có gradient
                using (SolidBrush backgroundBrush = new SolidBrush(_backgroundColor))
                {
                    e.Graphics.FillRectangle(backgroundBrush, this.ClientRectangle);
                }
            }

            // Vẽ viền của panel
            using (Pen borderPen = new Pen(_borderColor, _borderWidth))
            {
                e.Graphics.DrawRectangle(borderPen, new Rectangle(0, 0, this.Width - _borderWidth, this.Height - _borderWidth));
            }

            // Vẽ góc bo nếu được chỉ định
            if (_borderRadius > 0)
            {
                using (GraphicsPath path = RoundedRectangle.Create(this.ClientRectangle, _borderRadius))
                {
                    this.Region = new Region(path);
                }
            }
        }
    }

    public static class RoundedRectangle
    {
        public static GraphicsPath Create(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // Top-left arc
            path.AddArc(arc, 180, 90);

            // Top-right arc
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Bottom-right arc
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Bottom-left arc
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();

            return path;
        }
    }
}
