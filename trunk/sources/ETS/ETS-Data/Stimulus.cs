using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml.Serialization;
using System.IO;
using System.Drawing.Imaging;
using System.Xml;

namespace ETS_Data
{

    public class Stimulus
    {
        private Point place;

        public Point Place
        {
            get { return place; }
            set { place = value; }
        }
      
        private Bitmap picture;
        [XmlIgnore]
        public Bitmap Picture
        {
            get { return picture; }
            set { picture = value; }
        }
        public string PictureArray
        {
            get {
                using (MemoryStream ms = new MemoryStream())
                {
                    Picture.Save(ms, ImageFormat.Png);
                    byte[] tmp = ms.ToArray();
                    return Convert.ToBase64String(tmp, 0, tmp.Length);
                }
            
            }
            set {
                byte[] tmp = Convert.FromBase64String(value);
                using(MemoryStream ms = new MemoryStream(tmp))
                {
                    Picture = new Bitmap(ms);
                }
            }
        }


        private double probability;

        public double Probability
        {
            get { return probability; }
            set { probability = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
