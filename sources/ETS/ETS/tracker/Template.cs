using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Emgu.CV.Structure;
using Emgu.CV;
using System.Collections;
using ETS.Properties;
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

        public Template(Rectangle rect, Image<Gray, Byte> tpl)
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



        internal void Save(System.IO.StreamWriter sw, string fileName)
        {
            sw.WriteLine(Name);
            sw.WriteLine(string.Format(Resources.RectSerializationFormat, new object[] { Rect.X, Rect.Y, Rect.Width, Rect.Height }));
            sw.WriteLine(Coords.Count);
            for (int i = 0; i < Coords.Count; i++)
            {
                Rectangle r = (Rectangle)Coords[i];
                sw.WriteLine(string.Format(Resources.RectSerializationFormat, new object[]{r.X,r.Y,r.Width,r.Height}));
            }
           
           Tpl.Save(Path.Combine(Path.GetDirectoryName(fileName),Name)+".png");
        }
        public void Load(System.IO.StreamReader sr, string fileName)
        {
            Name = sr.ReadLine();
            string r = sr.ReadLine();
            string[] tokens = r.Split(',');
            Rect = new Rectangle(int.Parse(tokens[0]),int.Parse(tokens[1]),int.Parse(tokens[2]),int.Parse(tokens[3]));
            int count = int.Parse(sr.ReadLine());
            Coords = new ArrayList();
            for (int i = 0; i < count; i++)
            {
                string str = sr.ReadLine();
                string[] tok = str.Split(',');
                Rectangle re = new Rectangle(int.Parse(tok[0]), int.Parse(tok[1]), int.Parse(tok[2]), int.Parse(tok[3]));
                Coords.Add(re);
            }
               Tpl = new Image<Gray, byte>(Path.Combine(Path.GetDirectoryName(fileName),Name)+".png");
        }
    }
}
