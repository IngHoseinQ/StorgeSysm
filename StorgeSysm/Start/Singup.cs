using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorgeSysm.Start
{
    public partial class Singup : DevExpress.XtraEditors.XtraForm
    {
 
        public Singup()
        {
            InitializeComponent();
        }

        private void singup_btn_Click(object sender, EventArgs e)
        {
            if (username.Text == "" && password.Text == "" && Fullname.Text =="")
            {
                MessageBox.Show("قم ب ادخال البيانات الايمكن ان تكون البيانات فارغة", "خطا ", MessageBoxButtons.OK, MessageBoxIcon.Warning,
               MessageBoxDefaultButton.Button1,
               MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
            else
            {
            

                    var dilogeresult = MessageBox.Show("  يجب اعادة تشغبل النظام ليتم حفظ التغيرات اضغط نعم", "اعادة تشغبل", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dilogeresult == DialogResult.Yes)
                    {
                    try
                    {
                        SyStorgeDataEntities db = new SyStorgeDataEntities();
                        Users add = new Users()
                        {

                            Fullname = Fullname.Text,
                            Username = username.Text,
                            Password = password.Text,
                            Users_type = Type_text.Text
                        };
                        db.Entry(add).State = System.Data.Entity.EntityState.Added;
                        db.SaveChanges();
                        String appPath=Assembly.GetEntryAssembly().Location;
                        Process.Start(appPath);
                        Environment.Exit(0);

                    }
                    catch
                    {
                        MessageBox.Show("خطأ , لطفا تحقق من متطلبات الادخال والاتصال بالسيرفر", "خطا في عملية الدخول", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                          MessageBoxDefaultButton.Button1,
                          MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    }
                }

              
            }
           
        }

        private void Singup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}