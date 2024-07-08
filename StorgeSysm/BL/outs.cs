using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace StorgeSysm.BL
{
    public partial class outs : DevExpress.XtraReports.UI.XtraReport
    {
        public int outid;
        public outs()
        {
            InitializeComponent();
            outid = Properties.Settings.Default.IDCoustmer;
            IDO.Value = outid;
            IDO.AllowNull = false;
        }

    }
}
