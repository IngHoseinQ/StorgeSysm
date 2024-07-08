using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace StorgeSysm.BL
{
    public partial class com : DevExpress.XtraReports.UI.XtraReport
    {
        public int idcoms;
        public com()
        {
            InitializeComponent();
            idcoms = Properties.Settings.Default.IDIncoming;
            ID.Value = idcoms;
            ID.AllowNull = false;
        }
       
     
     
        
    }
}
