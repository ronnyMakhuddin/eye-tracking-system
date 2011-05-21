using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ETS_Data;
using System.Media;
using System.Threading;

namespace ETS.ui
{
    public partial class SeriesPlayer : Form
    {
        private Series series;
        public delegate void StartEventHandler();
        public event StartEventHandler OnStart;
        public SeriesPlayer(Series series)
        {
            InitializeComponent();
            this.series = series;
            Screen[] sc = Screen.AllScreens;
            this.WindowState = FormWindowState.Maximized;
            if (sc.Length > 1)
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.StartPosition = FormStartPosition.Manual;
                this.Left = sc[1].Bounds.Left; 
                this.Top = sc[1].Bounds.Top;
            }
           
        }
        private void SetFormLocation(Form form, Screen screen)
        {
            // first method
            Rectangle bounds = screen.Bounds;
            form.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);

            // second method
            //Point location = screen.Bounds.Location;
            //Size size = screen.Bounds.Size;

            //form.Left = location.X;
            //form.Top = location.Y;
            //form.Width = size.Width;
            //form.Height = size.Height;

        }
        public void ShowStimul(Stimulus stimul)
        {
            switch (stimul.Type)
            {
                case StimulusType.PICTURE:
                    {
                        if (stimul.PictureData == null)
                        {
                            stimul.PictureData = LoadImage(stimul);
                        }
                        SetPictureLocation(stimul.Pos);
                        image.Image = stimul.PictureData;
                    }
                    break;
                case StimulusType.SOUND:
                    {
                        SoundPlayer simpleSound = new SoundPlayer(stimul.Filename);
                        simpleSound.Play();
                    }
                    break;
            }
        }

        private Bitmap LoadImage(Stimulus stimul)
        {
            String filename = stimul.Filename;
            Bitmap bmp = new Bitmap(filename);
            return bmp;
        }
        public void SetPictureLocation(Position id)
        {
            switch (id)
            {
                case Position.CENTER:
                    image.Location = new Point(
                        this.Size.Width / 2 - image.Size.Width / 2,
                        this.Size.Height / 2 - image.Size.Height / 2
                    );
                    break;
                case Position.UP:
                    image.Location = new Point(
                       this.Size.Width / 2 - image.Size.Width / 2,
                       0
                   );

                    break;
                case Position.DOWN:
                    image.Location = new Point(
                      this.Size.Width / 2 - image.Size.Width / 2,
                      this.Size.Height - image.Height
                  );
                    break;
                case Position.LEFT:
                    image.Location = new Point(
                      0,
                      this.Size.Height / 2 - image.Size.Height / 2
                  );
                    break;
                case Position.RIGHT:
                    image.Location = new Point(
                      this.Size.Width - image.Size.Width,
                      this.Size.Height / 2 - image.Size.Height / 2
                  );
                    break;
                case Position.DOWN_LEFT:
                    image.Location = new Point(
                      0,
                      this.Size.Height - image.Size.Height
                  );
                    break;
                case Position.DOWN_RIGHT:
                    image.Location = new Point(
                      this.Size.Width - image.Size.Width,
                      this.Size.Height - image.Size.Height
                  );
                    break;
                case Position.UPPER_LEFT:

                    image.Location = new Point(
                      0,
                      0
                  );
                    break;
                case Position.UPPER_RIGHT:

                    image.Location = new Point(
                      this.Size.Width - image.Size.Width,
                      0
                  );
                    break;
            }
        }

        public void ShowStartText()
        {
            HideLabel();
            ShowLabel(series.Config.TextBefore);
            btnStartTest.Visible = true;
        }
        public void ShowLabel(string text)
        {
            lblText.Text = text;
            lblText.Visible = true;
           
        }
        public void HideLabel()
        {
            lblText.Visible = false;
        }
        public void ShowEndText()
        {
            ShowLabel(series.Config.TextAfter);
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            HideLabel();
            btnStartTest.Visible = false;
            if (OnStart != null)
            {
                OnStart();
            }
        }

        public void HideAll()
        {
            HideLabel();
            btnStartTest.Visible = false;
        }
    }
}
