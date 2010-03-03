using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Emgu.CV;

namespace ETS.tracker
{
    public class CaptureManager
    {
        private Capture cameraCapture;

        public Capture CameraCapture
        {
            get { return cameraCapture; }
            set { cameraCapture = value; }
        }

        public CaptureManager()
        {
            cameraCapture = new Capture();
        }
        public IImage QueryFrame()
        {
            return CameraCapture != null ? CameraCapture.QueryFrame() : null;
        }
    }
}
