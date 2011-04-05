using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Emgu.CV.Structure;
using Emgu.CV;
using System.Collections;

using System.IO;

namespace ETS.tracker
{
    public class Template
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        Rectangle rect;

        public Rectangle Rect
        {
            get { return rect; }
            set { rect = value; }
        }
        Image<Gray, Byte> tpl;

        public Image<Gray, Byte> Tpl
        {
            get { return tpl; }
            set { tpl = value; }
        }

        private ArrayList coords;

        public ArrayList Coords
        {
            get { return coords; }
            set { coords = value; }
        }
        private bool added;
        public bool Added
        {
            get { return added; }
            set { added = value; }
        }

        public Template(Rectangle rect, Image <Gray, Byte> tpl)
        {
            this.rect = rect;
            this.tpl = tpl;
            this.Coords = new ArrayList();
            added = false;
            this.Name = string.Empty;
        }
        public Template()
        {
            Rect = Rectangle.Empty;
            Tpl = null;
            Coords = new ArrayList();
            Added = true;
            Name = string.Empty;
        }

       
        public bool IsEmpty
        {
            get { return tpl == null || Rect == Rectangle.Empty || Rect.Width == 0 || Rect.Height == 0; }
        }
        public static Template Empty
        {
            get { return new Template(new Rectangle(), null); }
        }
        public Rectangle GetMatchingRegion(Image<Gray, Byte> image)
        {
            if (IsEmpty)
            {
                return Rectangle.Empty;
            }
            Image<Gray, float> tm;
            Point[] minloc, maxloc;
            double[] minval, maxval;
            tm = image.MatchTemplate(Tpl, Emgu.CV.CvEnum.TM_TYPE.CV_TM_SQDIFF_NORMED);
            tm.MinMax(out minval, out maxval, out minloc, out maxloc);
            return new Rectangle(minloc[0], Rect.Size);
        }
        public Rectangle GetLastCoordinate()
        {
            return Coords != null && Coords.Count != 0 ? (Rectangle)Coords[Coords.Count - 1] : Rectangle.Empty;
        }

        public Rectangle QueryCoordinate(Image <Gray,Byte> image){
            Rectangle rect = GetMatchingRegion(image);
            Rectangle prev = GetLastCoordinate();
         
            Rectangle current = Rectangle.Empty;
            if ((rect.X < prev.X - prev.Width || rect.X > prev.X + prev.Width || rect.Y < prev.Y - prev.Height || rect.Y > prev.Y + prev.Height) && (prev != Rectangle.Empty))
            {
                current = prev;
            }
            else
            {
                current = rect;
            }
            
            return current;
        }



      
    }
}
