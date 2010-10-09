using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ETS_Data
{
    public class SeriesRecord
    {
        /// <summary>
        /// Стимулы в момент времени
        /// </summary>
        private ArrayList stimulusArray;

        public ArrayList StimulusArray
        {
            get { return stimulusArray; }
            set { stimulusArray = value; }
        }
        private Hashtable templateDirectionMap;

        public Hashtable TemplateDirectionMap
        {
            get { return templateDirectionMap; }
            set { templateDirectionMap = value; }
        }
        private char keyPressed;

        public char KeyPressed
        {
            get { return keyPressed; }
            set { keyPressed = value; }
        }
        private int keyPressedTimeLength;

        public int KeyPressedTimeLength
        {
            get { return keyPressedTimeLength; }
            set { keyPressedTimeLength = value; }
        }
    }
}
