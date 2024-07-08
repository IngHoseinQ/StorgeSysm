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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        String name;
        bool state;
        SyStorgeDataEntities db;
        Users check;
        public Login()
        {
            InitializeComponent();


        }
        private bool Chk_login()

        {
            try
            {

                db = new SyStorgeDataEntities();
                name = db.Users.Where(x => x.Username == username.Text && x.Password == password.Text).Select(x=>x.Fullname).First();
                check = db.Users.Where(x => x.Username == username.Text && x.Password == password.Text).FirstOrDefault();

                if (check == null)
                {
                    state = false;
                }
                else
                {
                    state = true;
                }


            }
            catch{
                state = false;
                MessageBox.Show("خطأ , لطفا تحقق من متطلبات الادخال والاتصال بالسيرفر", "خطا في عملية الدخول", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                  MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
               
            }
            return state;
        }


        private void Login_btn_Click(object sender, EventArgs e)
        {
            if(username.Text==null && password.Text == null)
            {
                MessageBox.Show("قم ب ادخال البيانات الايمكن ان تكون البيانات فارغة", "خطا في عملية الدخول", MessageBoxButtons.OK, MessageBoxIcon.Warning,
               MessageBoxDefaultButton.Button1,
               MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
            else
            {
                Chk_login();
                if (state == false)
                {
                    MessageBox.Show("خطأ , لطفا تحقق من متطلبات الادخال والاتصال بالسيرفر", "خطا في عملية الدخول", MessageBoxButtons.OK, MessageBoxIcon.Warning,
    MessageBoxDefaultButton.Button1,
  MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                }
                else
                {

                    Home H = new Home();
                    H.Get_name.Caption = name;
                    H.Show();
                    this.Hide();

                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_btn_Click(sender, e);
            }
        }
    }
}