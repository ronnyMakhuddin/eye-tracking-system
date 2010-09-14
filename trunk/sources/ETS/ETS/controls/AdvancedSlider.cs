using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ETS.controls
{
    public partial class AdvancedSlider : UserControl
    {
        public delegate void ValueChangedEventHandler(int value);
        public event ValueChangedEventHandler ValueChanged;
        public string CaptionText
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }
        public int Minimum
        {
            get { return slider.Minimum; }
            set { slider.Minimum = value; }
        }
        public int Maximum
        {
            get { return slider.Maximum; }
            set { slider.Maximum = value; }
        }
        public int Value
        {
            get { return slider.Value; }
            set { if (value <= slider.Maximum) { slider.Value = value; } else { slider.Value = slider.Maximum - 1; } }
        }

        public AdvancedSlider()
        {
            InitializeComponent();
            lblValue.Text = Value.ToString();
        }

        private void slider_ValueChanged(object sender, EventArgs e)
        {
            lblValue.Text = slider.Value.ToString();
            if (ValueChanged != null)
            {
                ValueChanged(slider.Value);
            }
        }
    }
}
