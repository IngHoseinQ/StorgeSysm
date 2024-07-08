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
    public partial class Type_prices : DevExpress.XtraEditors.XtraForm
    {
        Type_Price add;
        public int id;
        SyStorgeDataEntities db;
        public Type_prices()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            StorgeSysm.SyStorgeDataEntities dbContext = new StorgeSysm.SyStorgeDataEntities();
            dbContext.Type_Price.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.Type_Price.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                AddT page = new AddT();
                page.btn_add.Text = "اضافة";
                page.edt_name.Text = "";
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
                add = new Type_Price();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("Id"));
                if (id != 0)
                {
                    add = db.Type_Price.Where(x => x.Id == id).FirstOrDefault();
                    AddT page = new AddT();
                    page.btn_add.Text = "تعديل";
                    page.edt_name.Text = add.Name;
                    page.edit_type.Text = add.Type.ToString();
           
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
                add = new Type_Price();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("Id"));
                if (id != 0)
                {
                    var dilogeresult = MessageBox.Show(" هل انت متأكد من هذا الاجراء , لا يمكن استرجاع البيانات , سيتم حذف جميع البيانات المرتبطة ", "اجراء حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dilogeresult == DialogResult.Yes)
                    {
                        add = db.Type_Price.Where(x => x.Id == id).FirstOrDefault();
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

        }
    }
}