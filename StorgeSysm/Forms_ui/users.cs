using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorgeSysm.Forms_ui
{
    public partial class users : DevExpress.XtraEditors.XtraUserControl
    {
        public users()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            StorgeSysm.SyStorgeDataEntities dbContext = new StorgeSysm.SyStorgeDataEntities();
            dbContext.Users.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.Users.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }
    }
}
