using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using ETS.Properties;

namespace ETS.tracker
{
    public class Eye
    {
        private Rectangle rect;

        public Rectangle Rect
        {
            get { return rect; }
            set { rect = value; }
        }

        public Point Center {
            get { 
                return Rect != Rectangle.Empty ? new Point(Rect.Location.X + Rect.Width/2,Rect.Location.Y + Rect.Height/2) : Point.Empty;
            }
        }

        public Rectangle BoundingRect
        {
            get {
                return new Rectangle(
                    Center.X - (int)(Settings.Default.AnalyticWidth / 2),
                    Center.Y - (int)(Settings.Default.AnalyticHeight / 2),
                    (int)Settings.Default.AnalyticWidth,
                    (int)Settings.Default.AnalyticHeight
                );
            }
        }

        public Eye(Rectangle rect)
        {
            this.rect = rect;
        }
    }
}
