using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETS_Data
{
    public class Util
    {
        public static string MsToStandardTimeRepresentation(int ms)
        {
            TimeSpan tsValue = TimeSpan.FromMilliseconds((double)(ms));
            return string.Format("{0:D2}:{1:D2}:{2:D2}:{3:D3} ", tsValue.Hours, tsValue.Minutes, tsValue.Seconds, tsValue.Milliseconds);

        }
    }
}
