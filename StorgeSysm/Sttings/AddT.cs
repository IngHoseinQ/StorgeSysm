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
    public partial class AddT : DevExpress.XtraEditors.XtraForm
    {
        public int id;
        bool state;
        Type_Price add;
        SyStorgeDataEntities db;
        public Type_prices page;
        public AddT()
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
                add = db.Type_Price.Where(x => x.Name == edt_name.Text).FirstOrDefault();
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
            int num;
            if (edt_name.Text == "")
            {
                Message("اكمل الحقل لطفا", Color.Red);
            }
            if (edit_type.Text == "")

            {

                Message(" يجب اضافة سعر صرف ", Color.Red);
            }
            else if (!int.TryParse(edit_type.Text, out num))
            {

                Message("الحقل  سعر صرف  ارقام فقط", Color.Red);
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
                        Message("الالية موجودة مسبقا", Color.Blue);

                    }
                    else
                    {
                        // Add
                        AddData();
                        state = true;
                        page.LoadData();






                    }

                }

                else
                {
                    // Add
                    EditData();
                    state = true;
                    page.LoadData();

                }


              
            }
            return state;
        }
    
        private void EditData()
        {
            try
            {
                db = new SyStorgeDataEntities();
                add = new Type_Price
                {
                    Id = id,
                    Name = edt_name.Text,

                    Type =Convert.ToDouble( edit_type.Text),



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
                add = new Type_Price
                {
                    Name = edt_name.Text,

                    Type =Convert.ToDouble(edit_type.Text),


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