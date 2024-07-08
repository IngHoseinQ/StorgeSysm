using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StorgeSysm.Frm_addS;
using System.Data.Entity;
namespace StorgeSysm.Forms_ui
{
    public partial class storge : DevExpress.XtraEditors.XtraUserControl
    {
       
        STORAGE add;
        public int id;
        SyStorgeDataEntities db;

        public storge()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            StorgeSysm.SyStorgeDataEntities dbContext = new StorgeSysm.SyStorgeDataEntities();
            dbContext.STORAGE.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.STORAGE.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
  


        private void storge_Load(object sender, EventArgs e)
        {
            
            LoadData();
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Form_AddS page = new Form_AddS();
                page.btn_add.Text = "اضافة";
                page.btn_addclose.Text = "اضافة + غلق";
                page.edt_name_s.Text = "";
                page.id = 0;
                page.page = this;
                page.Show();
            }
            catch { MessageBox.Show("خطأ غير متوقع"); }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                db = new SyStorgeDataEntities();
                add = new STORAGE();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("Id"));
                if (id != 0)
                {
                    add = db.STORAGE.Where(x => x.Id == id).FirstOrDefault();
                    Form_AddS page = new Form_AddS();
                    page.btn_add.Text = "تعديل";
                    page.btn_addclose.Text = "تعديل + غلق";
                    page.edt_name_s.Text = add.StoreName;
                    page.edt_name_as.Text = add.KeeperName;
                    page.edt_name_ds.Text = add.deckTitle;
                    page.id = id;
                    page.page = this;
                    page.Show();
                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات لتعديلها, اختر صف لتعديله", "لا يمكن اجراء العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            catch
            {
                MessageBox.Show("خطأ في الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                db = new SyStorgeDataEntities();
                add = new STORAGE();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("Id"));
                if (id != 0)
                {
                    var dilogeresult = MessageBox.Show(" هل انت متأكد من هذا الاجراء , لا يمكن استرجاع البيانات , سيتم حذف جميع البيانات المستخدم بشكل دائم", "اجراء حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dilogeresult == DialogResult.Yes)
                    {
                        add = db.STORAGE.Where(x => x.Id == id).FirstOrDefault();
                        db.Entry(add).State =System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        LoadData();

             

                    }

                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات لحذفها", "لا يمكن اجراء العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            catch
            {
                MessageBox.Show("خطأ في الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
           LoadData();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void storge_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
