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

namespace StorgeSysm.Sttings
{
    public partial class Unitss : DevExpress.XtraEditors.XtraForm
    {
        Units add;
        public int id;
        SyStorgeDataEntities db;
        public Unitss()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            StorgeSysm.SyStorgeDataEntities dbContext = new StorgeSysm.SyStorgeDataEntities();
            dbContext.Units.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.Units.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void Units_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                AddW page = new AddW();
                page.btn_add.Text = "اضافة";
                page.edt_name.Text = "";
                page.id = 0;
                page.pagew = this;
                page.Show();
            }
            catch { MessageBox.Show("خطأ غير متوقع"); }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                db = new SyStorgeDataEntities();
                add = new Units();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("Id"));
                if (id != 0)
                {
                    var dilogeresult = MessageBox.Show(" هل انت متأكد من هذا الاجراء , لا يمكن استرجاع البيانات , سيتم حذف جميع البيانات المرتبطة ", "اجراء حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dilogeresult == DialogResult.Yes)
                    {
                        add = db.Units.Where(x => x.Id == id).FirstOrDefault();
                        db.Entry(add).State = System.Data.Entity.EntityState.Deleted;
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                db = new SyStorgeDataEntities();
                add = new Units();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("Id"));
                if (id != 0)
                {
                    add = db.Units.Where(x => x.Id == id).FirstOrDefault();
                    AddW page = new AddW();
                    page.btn_add.Text = "تعديل";
                    page.edt_name.Text = add.unit_name;


                    page.id = id;
                    page.pagew = this;
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
    }
}