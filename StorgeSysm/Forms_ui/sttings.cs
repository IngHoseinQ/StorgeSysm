using DevExpress.XtraEditors;
using StorgeSysm.Sttings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorgeSysm.Forms_ui
{
    public partial class sttings : DevExpress.XtraEditors.XtraUserControl
    {
        public sttings()
        {
            InitializeComponent();
        }

        private void btn_open_tps_Click(object sender, EventArgs e)
        {
            Type_prices TP = new Type_prices();
            TP.Show();
        }

        private void btn_open_uns_Click(object sender, EventArgs e)
        {
            Unitss U = new Unitss();
            U.Show();
        }

        private void db_btn_Click(object sender, EventArgs e)
        {
            SttingCon sttingCon = new SttingCon();
            sttingCon.Show();
        }
    }
}
