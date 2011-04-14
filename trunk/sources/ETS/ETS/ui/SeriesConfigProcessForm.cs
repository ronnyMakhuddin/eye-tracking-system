using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ETS_Data;

namespace ETS.ui
{
    public partial class SeriesConfigProcessForm : Form
    {
        private SeriesConfig config;
        private int currentStimul;
        public SeriesConfigProcessForm(SeriesConfig config)
        {
            InitializeComponent();
            this.config = config;
            currentStimul = 0;
            this.WindowState = FormWindowState.Maximized;
            timer.Interval = (int)config.MinInt;
            timer.Enabled = true;
            timer.Start();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (currentStimul < config.StimulusOrder.Count)
            {
                long stimId = (long)config.StimulusOrder[currentStimul];
                foreach (Stimulus s in config.StimulusSet)
                {
                    if (s.Id == stimId)
                    {
                        label1.Text = "Schedule stim " + s.Name;
                        SetPictureLocation(s.Pos);
                    }
                }
                currentStimul++;
            }
            else
            {
                timer.Enabled = false;
            }
        }
        public void SetPictureLocation(Position id)
        {
            switch (id)
            {
                case Position.CENTER:
                    pbxPicture.Location = new Point(
                        this.Size.Width / 2 - pbxPicture.Size.Width / 2,
                        this.Size.Height / 2 - pbxPicture.Size.Height / 2
                    );
                    break;
                case Position.UP:
                    pbxPicture.Location = new Point(
                       this.Size.Width / 2 - pbxPicture.Size.Width / 2,
                       0
                   );

                    break;
                case Position.DOWN:
                    pbxPicture.Location = new Point(
                      this.Size.Width / 2 - pbxPicture.Size.Width / 2,
                      this.Size.Height - pbxPicture.Height
                  );
                    break;
                case Position.LEFT:
                    pbxPicture.Location = new Point(
                      0,
                      this.Size.Height / 2 - pbxPicture.Size.Height / 2
                  );
                    break;
                case Position.RIGHT:
                    pbxPicture.Location = new Point(
                      this.Size.Width - pbxPicture.Size.Width,
                      this.Size.Height / 2 - pbxPicture.Size.Height / 2
                  );
                    break;
                case Position.DOWN_LEFT:
                    pbxPicture.Location = new Point(
                      0,
                      this.Size.Height  - pbxPicture.Size.Height
                  );
                    break;
                case Position.DOWN_RIGHT:
                    pbxPicture.Location = new Point(
                      this.Size.Width - pbxPicture.Size.Width,
                      this.Size.Height - pbxPicture.Size.Height
                  );
                    break;
                case Position.UPPER_LEFT:

                    pbxPicture.Location = new Point(
                      0,
                      0
                  );
                    break;
                case Position.UPPER_RIGHT:

                    pbxPicture.Location = new Point(
                      this.Size.Width-pbxPicture.Size.Width,
                      0
                  );
                    break;
            }
        }
        private void SeriesConfigProcessForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
        }

        private void SeriesConfigProcessForm_Resize(object sender, EventArgs e)
        {
            pbxPicture.Size = new Size(this.Size.Width / 2, this.Size.Height / 2);
        }
    }
}
