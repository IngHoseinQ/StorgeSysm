
using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorgeSysm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
             bool v = Properties.Settings.Default.state;
          
            Application.EnableVisualStyles();
            if (v == true)
            {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(DevExpress.LookAndFeel.SkinSvgPalette.WXI);  
            }else if(v == false)
            {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(DevExpress.LookAndFeel.SkinSvgPalette.WXI.Darkness);

            }
            Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.ClientAndNonClientAreasEnabled;  
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start.Start());
        }
    }
}
