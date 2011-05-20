using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using ETS.Properties;

namespace ETS
{
    public class Util
    {
        public static void ShowError(string message)
        {
            MessageBox.Show(message, Resources.ERROR,MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
        }
        public static void ShowInfo(string message)
        {
            MessageBox.Show(message, Resources.INFO, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        public static string MsToStandardTimeRepresentation(int ms)
        {
            TimeSpan tsValue = TimeSpan.FromMilliseconds((double)(ms));
            return string.Format("{0:D2}:{1:D2}:{2:D2}:{3:D3} ", tsValue.Hours, tsValue.Minutes, tsValue.Seconds, tsValue.Milliseconds);

        }
    }
}
