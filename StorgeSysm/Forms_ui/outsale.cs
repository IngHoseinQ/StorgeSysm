using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using StorgeSysm.BL;
using StorgeSysm.Frm_addS;
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
    public partial class outsale : DevExpress.XtraEditors.XtraUserControl
    {
        Coustmer add;
        public int Idds;
        SyStorgeDataEntities db;
        public outsale()
        {
            InitializeComponent();
            
           LoadData();
        }
        public void LoadData()

        {
            stat.ValueChecked = false;
            StorgeSysm.SyStorgeDataEntities dbContext = new StorgeSysm.SyStorgeDataEntities();
            dbContext.Coustmer.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.Coustmer.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void CheckState()
        {
            int isCheck = 1;
            int isunCheck = 0;
            repositoryItemCheckEdit1.ValueChecked = isCheck;
            repositoryItemCheckEdit1.ValueUnchecked = isunCheck;


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                add_zpon page = new add_zpon();
                page.btn_add.Text = "اضافة";
                page.edt_name_p.Text = "";
                page.textBox1.Text = "";
                page.id = 0;
                page.pageo = this;
                page.Show();
            }
            catch { MessageBox.Show("خطأ غير متوقع"); }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {

                SyStorgeDataEntities db = new SyStorgeDataEntities();
                Coustmer add = new Coustmer();
                Idds = Convert.ToInt16(gridView1.GetFocusedRowCellValue("Id"));
                if (Idds != 0)
                {
                    
                    add = db.Coustmer.Where(x => x.Id == Idds).FirstOrDefault();
                    Form_AddOUTC page = new Form_AddOUTC();
                    page.btn_add.Text = "اضافة محتويات";
                    page.name_mord.Text = add.Coustmer_Name;
                    page.entity_mord.Text = add.Coustmer_Entity;
                    page.getform = false;
                    page.idSelcedt = Idds;
                    page.mord_date.DateTime = DateTime.Now;
                    page.State_snad = (int)add.State;
                    page.page = this;
                    page.Show();
                }
                else
                {
                    MessageBox.Show("لا يمكن إجراء العملية قم ب اضافة عميل اولا", "لا يوجد بيانات الاضافتها ",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning,
                 MessageBoxDefaultButton.Button1,
                 MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "خطأ في الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Information,
                 MessageBoxDefaultButton.Button1,
                 MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {

                db = new SyStorgeDataEntities();
                add = new Coustmer();

                Idds = Convert.ToInt16(gridView1.GetFocusedRowCellValue("Id"));
                if (Idds != 0)
                {
                    add = db.Coustmer.Where(x => x.Id == Idds).FirstOrDefault();
                    Form_AddOUTC page = new Form_AddOUTC();
                    page.btn_add.Text = "تعديل المحتويات";
                    page.name_mord.Text = add.Coustmer_Name;
                    page.entity_mord.Text = add.Coustmer_Entity;
                    page.mord_date.DateTime = (DateTime)add.Coustmer_Date;
                    page.mord_date.Enabled = false;
                    page.idSelcedt = Idds;
                    page.getform = true;
                    page.State_snad = (int)add.State;
                    page.page = this;
                    page.Show();
                }
                else
                {
                    MessageBox.Show("لا يمكن إجراء العملية قم ب اضافة عميل اولا", "لا يوجد بيانات لتعديلها ",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning,
                 MessageBoxDefaultButton.Button1,
                 MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

                }


            }
            catch
            {
                MessageBox.Show("خطأ في الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Information,
                 MessageBoxDefaultButton.Button1,
                 MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                db = new SyStorgeDataEntities();
                add = new Coustmer();
                Idds = Convert.ToInt16(gridView1.GetFocusedRowCellValue("Id"));
                if (Idds != 0)
                {
                    var dilogeresult = MessageBox.Show("هل انت متأكد من هذا الاجراء , لا يمكن استرجاع البيانات ابدا , سيتم حذف جميع البيانات المرتبطة بالسند", "اجراء حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dilogeresult == DialogResult.Yes)
                    {
                        add = db.Coustmer.Where(x => x.Id == Idds).FirstOrDefault();
                        db.Entry(add).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        LoadData();


                    }

                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات لحذفها", "لا يمكن اجراء العملية", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                 MessageBoxDefaultButton.Button1,
                 MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

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
            Idds = Convert.ToInt16(gridView1.GetFocusedRowCellValue("Id"));
            if (Idds != 0)
            {
                Properties.Settings.Default.IDCoustmer = Idds;
                Properties.Settings.Default.Save();
                ReportPrintTool printTool = new ReportPrintTool(new outs());
                printTool.AutoShowParametersPanel = false;
                printTool.ShowRibbonPreview();
            }
            else
            {
                MessageBox.Show("لا يمكن إجراء العملية ", "لا يوجد بيانات لطباعتها ",
             MessageBoxButtons.OK, MessageBoxIcon.Information,
             MessageBoxDefaultButton.Button1,
             MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

            }
        }

        private void outsale_Load(object sender, EventArgs e)
        {
            CheckState();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
