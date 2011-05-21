using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ETS_Data;

namespace ETS.controls
{
    public partial class CaptureSlider : UserControl
    {
        private Series series;
        public delegate void ValueChangedHandler(int value);
        public event ValueChangedHandler ValueChanged;
      
        public CaptureSlider()
        {
            InitializeComponent();
            slider.SmallChange = Constants.TIME_CHUNK_MS;
            slider.LargeChange = Constants.TIME_CHUNK_MS;
            slider.TickFrequency = Constants.TIME_CHUNK_MS;

        }
        public int Value
        {
            get { return slider.Value; }
            set
            {
                slider.Value = value;
                UpdateLabel(Value, Maximum);
            }
        }
        public int Maximum
        {
            get { return slider.Maximum; }
            set
            {
                slider.Maximum = Constants.TIME_CHUNK_MS * (value / Constants.TIME_CHUNK_MS);
                UpdateLabel(Value, Maximum);
            }
        }
        public int Minimum
        {
            get { return slider.Minimum; }
            set
            {
                slider.Minimum = value;
                UpdateLabel(Value, Maximum);
            }
        }
        private void btnIncrease_Click(object sender, EventArgs e)
        {
            if (Value + Constants.TIME_CHUNK_MS < slider.Maximum)
            {
                Value += Constants.TIME_CHUNK_MS;
            }
            else
            {
                Value = slider.Maximum;
            }
        }
        public void UpdateLabel(int value, int maximum)
        {
            TimeSpan tsValue = TimeSpan.FromMilliseconds((double)(Value));
            string val = string.Format("{0:D2}:{1:D2}:{2:D2}:{3:D3} ", tsValue.Hours, tsValue.Minutes, tsValue.Seconds, tsValue.Milliseconds);
            TimeSpan tsMaximum = TimeSpan.FromMilliseconds((double)(Maximum));
            string max = string.Format("{0:D2}:{1:D2}:{2:D2}:{3:D3} ", tsMaximum.Hours, tsMaximum.Minutes, tsMaximum.Seconds, tsMaximum.Milliseconds);
            lblTime.Text = val + " / " + max;
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if (Value - Constants.TIME_CHUNK_MS > 0)
            {
                Value -= Constants.TIME_CHUNK_MS;
            }
            else
            {
                Value = slider.Minimum;
            }
        }

        private void slider_ValueChanged(object sender, EventArgs e)
        {
            Value = (slider.Value / Constants.TIME_CHUNK_MS) * Constants.TIME_CHUNK_MS;
            if (ValueChanged != null)
            {
                ValueChanged(Value);
            }
        }

        public void InitWithSeries(ETS_Data.Series series)
        {
            this.series = series;
            if (series.Config.OrderTypeId == (long)Order.Fixed)
            {
                Minimum = 0;
                Maximum = (int)series.Length;
                Value = 0;
                long interval = series.Config.MaxInt;

                for (int i = 0; i < series.Config.SelectedStimulusSet.Count; i++)
                {
                    Stimulus s = (Stimulus)series.Config.SelectedStimulusSet[i];
                    StimulusWrapper sw = new StimulusWrapper();
                    sw.Stimul = s;
                    sw.TimePosition = (i+1) * (int)interval;
                    cmbStimuluses.Items.Add(sw);
                }
            }
            else
            {
            }




        }

        private void cmbStimuluses_SelectedValueChanged(object sender, EventArgs e)
        {
            StimulusWrapper sw = (StimulusWrapper)cmbStimuluses.SelectedItem;
            if (sw != null)
            {
                Value = sw.TimePosition;
            }
        }
        
    }
}
