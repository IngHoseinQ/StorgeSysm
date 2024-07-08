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
using System.Data.Entity;

namespace StorgeSysm.Frm_addS
{
    public partial class Form_AddP : DevExpress.XtraEditors.XtraForm
    {
        public int id;
        bool state;
        Parts add;
        SyStorgeDataEntities db;
        public colect_part page;
        public Form_AddINC page2;
        public int IDStorge;
        public Form_AddP()
        {
            InitializeComponent();

        }
        private void Message(string message,Color BackColors)
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
                add = db.Parts.Where(x => x.Part_Name == edt_name_p.Text && x.storge_id== IDStorge).FirstOrDefault();
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

            if (edt_name_p.Text =="")
            {
                Message("اكمل الحقل لطفا", Color.Red);
            }
           else if(comboBox_s.Text == ""){

                Message(" يجب اضافة مخزن لتخزين", Color.Red);
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
                        page.LoadData1();
                     






                    }

                }
                else
                {
                    // Edit
                    // Check Duplicate Data

                    // Edit
                    EditData();
                    state = true;
                    page.LoadData1();
                    




                }
            }
            return state;
        }
        private void AddData()
        {
            try
            {
                db = new SyStorgeDataEntities();
                add = new Parts
                {
                    Part_Name = edt_name_p.Text,
                    storge_id = IDStorge

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
                add = new Parts
                {
                    Id = id,
                    Part_Name = edt_name_p.Text,
                  
             

                    storge_id=IDStorge


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
                Message("تمت  العملية بنجاح", Color.Green);

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
        private void Form_AddP_Activated(object sender, EventArgs e)
        {
            LoadStorge();
            SetIDStorge();
        }
        public void LoadStorge()
        {
            try
            {
                db = new SyStorgeDataEntities();
                comboBox_s.DataSource=db.STORAGE.Select(x => x.StoreName).ToList();
                

            }
            catch { }
        }

        private void SetIDStorge()
        {
            try
            {
                db = new SyStorgeDataEntities();
                var id = db.STORAGE.Where(x => x.StoreName == comboBox_s.SelectedItem.ToString()).Select(x => x.Id).FirstOrDefault();
                IDStorge = id;

            }
            catch { }
        }


        private void link_addnewgroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Form_AddS page = new Form_AddS();
                storge page1 = new storge();
                page.btn_add.Text = "اضافة";
                page.btn_addclose.Text = "اضافة + غلق";
                page.edt_name_s.Text = "";
                page.id = 0;
                page.page = page1;
                page.Show();
            }
            catch { MessageBox.Show("خطأ غير متوقع"); }
        }

        private void Form_AddP_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_s_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox_s_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SetIDStorge();
        }
    }
   }
