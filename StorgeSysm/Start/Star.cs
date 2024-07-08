using DevExpress.XtraSplashScreen;
using StorgeSysm.Sttings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorgeSysm.Start
{
    public partial class Start : DevExpress.XtraEditors.XtraForm
    {
        int st;
        public Start()
        {
            InitializeComponent();
          
        }


        public enum SplashScreenCommand
        {
            
        }


        private async void  Start_Load(object sender, EventArgs e)
        {
            await Task.Run(() => Thread.Sleep(2000));

            // Check Login 

            lb_state.Text = "الاتصال بقاعدة البيانات..^_^..";
            var state = await Task.Run(() => CheckLogin());
            if (state == 1)
            {
                Login _Login = new Login();
                _Login.Show();
                Hide();
            }
            else if (state == 0)
            {
                Chose _ch = new Chose();
                _ch.Show();
                Hide();
            }
            else
            {
                DialogResult res = MessageBox.Show("خطأ في الاتصال في قاعدة البيانات , يبدو ان لديك مشكلة في عملية تثبيت البرنامج ", "هل تريد ضبط اعدادات الاتصال ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (res == DialogResult.OK)
                {

                    SttingCon user = new SttingCon();
                    user.Show();
                    
                }
                else
                {
                    Application.ExitThread();
                    Application.Exit();
                }

            }
        }

        private int CheckLogin()
        {
            try
            {
                SyStorgeDataEntities db = new SyStorgeDataEntities();

                var data = db.Users.Select(x => x.Fullname).ToList();
                if (data.Count > 0)
                {
                    st = 1;
                }
                else
                {
                    st = 0;
                }


            }
            catch
            {
                return 2;
            }
            return st;

        }


    }
}