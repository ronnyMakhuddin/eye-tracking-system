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
    public partial class SeriesPlayer : Form
    {
        private Series series;
        public SeriesPlayer(Series series)
        {
            InitializeComponent();
            this.series = series;
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
    }
}
