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

namespace StorgeSysm.Start
{
    public partial class Chose : DevExpress.XtraEditors.XtraForm
    {
        public Chose()
        {
            InitializeComponent();
        }

        private void db_btn_Click(object sender, EventArgs e)
        {
            Sttings.SttingCon _backup = new Sttings.SttingCon();
            _backup.isFrist = true;
            _backup.Show();
            Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Singup _Singup = new Singup();
            _Singup.Show();
            Close();
        }
    }
}