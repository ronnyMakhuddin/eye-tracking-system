using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETS_Data
{
    public class StimulusWrapper
    {
        private Stimulus stimul;

        public Stimulus Stimul
        {
            get { return stimul; }
            set { stimul = value; }
        }
        private int timePosition;

        public int TimePosition
        {
            get { return timePosition; }
            set { timePosition = value; }
        }
        public override String ToString()
        {
            return Stimul.Name.Trim() + "(" + Util.MsToStandardTimeRepresentation(TimePosition) + ")";
        }
    }
}
