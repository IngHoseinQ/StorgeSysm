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
using StorgeSysm.Forms_ui;

namespace StorgeSysm.Frm_addS
{
    public partial class Form_AddS : DevExpress.XtraEditors.XtraForm
    {
        public int id;
        bool state;
        STORAGE add;
        SyStorgeDataEntities db;
        public storge page;
        public Form_AddS()
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
                add = db.STORAGE.Where(x => x.StoreName == edt_name_s.Text).FirstOrDefault();
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
                Message("خطأ , لطفا تحقق من متطلبات الادخال والاتصال بالسيرفر",Color.Red);
            }


            return state;

        }
        private bool Save()
        {
            // check fields

            if (edt_name_s.Text == "" && edt_name_as.Text == "")
            {
                Message("اكمل الحقل لطفا", Color.Red);
            }
            else
            {
                // Add or edit
                var checkDuplicate = CheckDuplicateData();
                if (id == 0)
                {
                    // Add
                    // Check Duplicate Data

                    if (checkDuplicate == true)
                    {
                        Message("البيانات مكررة", Color.Blue);

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
                    // Edit
                    // Check Duplicate Data

                    // Edit
                    EditData();
                    state = true;
                    page.LoadData();
                 




                }
            }
            return state;
        }
        private void AddData()
        {
            try
            {
                db = new SyStorgeDataEntities();
                add = new STORAGE
                {
                    StoreName = edt_name_s.Text,
                    KeeperName = edt_name_as.Text,
                    deckTitle = edt_name_ds.Text,


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
        private void EditData()
        {
            try
            {
                db = new SyStorgeDataEntities();
                add = new STORAGE
                {
                    Id = id,
                    StoreName = edt_name_s.Text ,
                    KeeperName = edt_name_as.Text,
                    deckTitle = edt_name_ds.Text,


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
        private void btn_add_Click(object sender, EventArgs e)
        {
            var state = Save();
            if (state == true)
            {
                Message("تمت عملية العملية بنجاح", Color.Green);

            }
        }

        private void btn_addclose_Click(object sender, EventArgs e)
        {
            var state = Save();
            if (state == true)
            {
                Close();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_message.Visible = false;
            timer1.Enabled = false;
        }
    }
}