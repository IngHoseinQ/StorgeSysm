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
    public partial class incoming : DevExpress.XtraEditors.XtraUserControl
    {
        Incoming add;
        public int Ids;
 
        SyStorgeDataEntities db;
        public incoming()
        {
            InitializeComponent();
        
            LoadData();
        }
        public void LoadData()

        {
            stat.ValueChecked = false;
            StorgeSysm.SyStorgeDataEntities dbContext = new StorgeSysm.SyStorgeDataEntities();
            dbContext.Incoming.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.Incoming.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void CheckState ()
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
                add_mord page = new add_mord();
                page.btn_add.Text = "اضافة";
                page.edt_name_p.Text = "";
                page.textBox1.Text = "";
                page.id = 0;
              
                page.page = this;
                page.Show();
            }
            catch { MessageBox.Show("خطأ غير متوقع"); }
        }

        public void btn_print_Click(object sender, EventArgs e)
        {
            Ids = Convert.ToInt16(gridView1.GetFocusedRowCellValue("Id"));
            if (Ids != 0)
            {
                Properties.Settings.Default.IDIncoming = Ids;
                Properties.Settings.Default.Save();
                ReportPrintTool printTool = new ReportPrintTool(new com());
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                db = new SyStorgeDataEntities();
                add = new Incoming();
                Ids = Convert.ToInt16(gridView1.GetFocusedRowCellValue("Id"));
                if (Ids != 0)
                {
                    var dilogeresult = MessageBox.Show("هل انت متأكد من هذا الاجراء , لا يمكن استرجاع البيانات ابدا , سيتم حذف جميع البيانات المرتبطة بالسند", "اجراء حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dilogeresult == DialogResult.Yes)
                    {
                        add = db.Incoming.Where(x => x.Id == Ids).FirstOrDefault();
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

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void incoming_Load(object sender, EventArgs e)
        {
            CheckState();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {

                db = new SyStorgeDataEntities();
                add = new Incoming();

                Ids = Convert.ToInt16(gridView1.GetFocusedRowCellValue("Id"));
                if (Ids != 0)
                {
                    add = db.Incoming.Where(x => x.Id == Ids).FirstOrDefault();
                    Form_AddINC page = new Form_AddINC();
                    page.btn_add.Text = "تعديل المحتويات";
                    page.name_mord.Text = add.Supplier_Name;
                    page.entity_mord.Text = add.Supplier_Entity;
                    page.mord_date.DateTime = (DateTime)add.Incoming_Date;
                    page.mord_date.Enabled = false;  
                    page.idSelcedt = Ids;
                    page.getform = true;
                    page.State_snad = (int)add.State;
                    page.page = this;
                    page.Show();
                }
                else
                {
                    MessageBox.Show("لا يمكن إجراء العملية قم ب اضافة مورد اولا", "لا يوجد بيانات لتعديلها ",
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {

                SyStorgeDataEntities db = new SyStorgeDataEntities();
                Incoming add = new Incoming();
                Ids = Convert.ToInt16(gridView1.GetFocusedRowCellValue("Id"));
                if (Ids != 0)
                {
                    add = db.Incoming.Where(x => x.Id == Ids).FirstOrDefault();
                    Form_AddINC page = new Form_AddINC();
                    page.btn_add.Text = "اضافة محتويات";
                    page.name_mord.Text = add.Supplier_Name;
                    page.entity_mord.Text = add.Supplier_Entity;
                    page.getform = false;
                    page.idSelcedt = Ids;
                    page.mord_date.DateTime = DateTime.Now;
                    page.State_snad = (int)add.State;
                    page.page = this;
                    page.Show();
                }
                else
                {
                    MessageBox.Show("لا يمكن إجراء العملية قم ب اضافة مورد اولا", "لا يوجد بيانات الاضافتها ",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning,
                 MessageBoxDefaultButton.Button1,
                 MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString()+ "خطأ في الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Information,
                 MessageBoxDefaultButton.Button1,
                 MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

            }

        }
    }
    
    
}
