using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Drawing;
using System.Xml.Serialization;
using ETS_Data;

namespace ETS_Data_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Protocol test = new Protocol();
            Series s = new Series();
            s.Save("series.xml");
            test.AddSeries(s);
            test.Save("test.xml");

        }
    }
}
