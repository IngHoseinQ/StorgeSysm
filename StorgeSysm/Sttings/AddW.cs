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

namespace StorgeSysm.Sttings
{
    public partial class AddW : DevExpress.XtraEditors.XtraForm
    {
        public int id;
        bool state;
        Units add;
        SyStorgeDataEntities db;
        public Unitss pagew;
        public AddW()
        {
            InitializeComponent();
        }
        private void Message(string message, Color BackColors)
        {
            txt_message.Visible = true;
            timer1.Enabled = true;
            txt_message.Text = message;
            txt_message.BackColor = BackColors;
            state = false;
        }
        private bool CheckDuplicateData()
        {
            try
            {
                db = new SyStorgeDataEntities();
                add = db.Units.Where(x => x.unit_name == edt_name.Text).FirstOrDefault();
                if (add == null)
                {
                    state = false;
                }
                else
                {
                    state = true;
                }
            }
            catch
            {
                state = false;
                Message("خطأ , لطفا تحقق من متطلبات الادخال والاتصال بالسيرفر", Color.Red);
            }


            return state;

        }
        private bool Save()
        {
            // check fields
      
            if (edt_name.Text == "")
            {
                Message("اكمل الحقل لطفا", Color.Red);
            }

            else
            {
                var checkDuplicate = CheckDuplicateData();
                if (id == 0)
                {
                    // Add
                    // Check Duplicate Data

                    if (checkDuplicate == true)
                    {
                        Message("الصنف موجود مسبقا", Color.Blue);
                    }
                    else
                    {
                        // Add
                        AddData();
                        state = true;
                        pagew.LoadData();






                    }

                }

                else
                {
                    // Add
                    EditData();
                    state = true;
                    pagew.LoadData();

                }



            }
            return state;
        }

        private void EditData()
        {
            try
            {
                db = new SyStorgeDataEntities();
                add = new Units
                {
                    Id = id,
                    unit_name = edt_name.Text,





                };
                db.Entry(add).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("8c9a37c5-3ccb-4827-8b52-1efc3cbe49d6");

            }
            catch
            {
                Message("خطأ , لطفا تحقق من متطلبات الادخال والاتصال بالسيرفر", Color.Red);

            }
        }
        private void AddData()
        {
            try
            {
                db = new SyStorgeDataEntities();
                add = new Units
                {
                    unit_name = edt_name.Text,

                };
                db.Entry(add).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("ea880811-ab1c-4768-b05f-b7bbd078f2af");

            }
            catch
            {
                Message("خطأ , لطفا تحقق من متطلبات الادخال والاتصال بالسيرفر", Color.Red);

            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            var state = Save();
            if (state == true)
            {
                Close();

            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            txt_message.Visible = false;
            timer1.Enabled = false;
        }

    }
}