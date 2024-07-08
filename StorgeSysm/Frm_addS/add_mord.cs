using DevExpress.XtraEditors;
using StorgeSysm.Forms_ui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorgeSysm.Frm_addS
{
    public partial class add_mord : DevExpress.XtraEditors.XtraForm
    {
        public int id;
        bool state;
        Incoming add;
        SyStorgeDataEntities db;
        public incoming page;
        public Form_AddINC page2;
        public add_mord()
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

        private bool Save()
        {
            // check fields

            if (edt_name_p.Text == "")
            {
                Message("اكمل الحقل لطفا", Color.Red);
            }
            if (textBox1.Text == "")
            {

                Message(" يجب اضافة مخزن لتخزين", Color.Red);
            }
            else
            { 
                        // Add
                        AddData();
                        state = true;
                        page.LoadData();
       
            }
            return state;
        }
        private void AddData()
        {
            try
            {
                db = new SyStorgeDataEntities();
                add = new Incoming
                {
                    Supplier_Name = edt_name_p.Text,

                    Supplier_Entity = textBox1.Text,
               

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_message.Visible = false;
            timer1.Enabled = false;
        }
    }
}