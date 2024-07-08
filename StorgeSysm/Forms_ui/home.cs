using DevExpress.XtraEditors;
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
    public partial class home : DevExpress.XtraEditors.XtraUserControl
    {
        
        public home()
        {
            InitializeComponent();

        }

        private async void home_Load(object sender, EventArgs e)
        {
           lb_Time.Text= DateTime.Now.ToShortTimeString();
           lb_date.Text = DateTime.Now.Date.ToShortDateString();
        }
    }
}
