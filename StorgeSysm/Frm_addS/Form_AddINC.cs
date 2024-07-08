using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using StorgeSysm;
using StorgeSysm.BL;
using StorgeSysm.Forms_ui;
using StorgeSysm.Sttings;
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

namespace StorgeSysm.Frm_addS
{
    public partial class Form_AddINC : DevExpress.XtraEditors.XtraForm
    {
       
        Compart add;
        public int idSelcedt;
        public bool ISNew = true;
        public int PartID;
        public int TypePID;
        public int VTypePID;
        public int StrPartID;
        public int ComID;
        public Decimal One_B;
        public Decimal All_B;
        public int One_Q;
        public int All_Q;
        public int Compartid;
        public int State_snad;
        public double xx = 0;
        public double TyOfP ;
        public int StrID;
        public int UntID;
        public bool getform;
        public double gtall;
        public double ob;
        public double mi;
        SyStorgeDataEntities db;
        public incoming page;
        public Form_AddINC()
        {
  
            InitializeComponent();
            LoadData();
       
           
        }
        public void LoadData()
        {
            try
            {
                
                StorgeSysm.SyStorgeDataEntities dbContext = new StorgeSysm.SyStorgeDataEntities();
                
                gridControl1.DataSource = dbContext.Compart.Where(x => x.Id_coms == idSelcedt).ToList(); 
            }
            catch { }
        }
        /*
        public void LoadStorgelistnametxt()
        {
            try
            {
                db = new SyStorgeDataEntities();
                nameS_txt.AutoCompleteMode = AutoCompleteMode.Suggest;
                nameS_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;

                var storeNames = db.STORAGE.Select(x => x.StoreName).ToList();
                var autoCompleteSource = new AutoCompleteStringCollection();
                autoCompleteSource.AddRange(storeNames.ToArray());
                nameS_txt.AutoCompleteCustomSource = autoCompleteSource;

                nameS_txt.Leave += (sender, e) =>
                {
                    string completedText = CompleteText(nameS_txt.Text, storeNames);
                    nameS_txt.Text = completedText;
                };
            }
            catch { }
        }

        private string CompleteText(string text, List<string> suggestions)
        {
            if (string.IsNullOrEmpty(text))
            {
                return suggestions.FirstOrDefault();
            }
            else
            {
                string matchingItem = suggestions.FirstOrDefault(s => s == text);
                if (!string.IsNullOrEmpty(matchingItem))
                {
                    
                    return matchingItem;
                }
                else
                {
                   
                    return suggestions.FirstOrDefault(s => s == text);
                }
            }
        }

        public void listPartlistnametxt()
        {
            try
            {
                db = new SyStorgeDataEntities();
                comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

                var PartNames = db.Parts.Where(x => x.storge_id == StrID).Select(x => x.Part_Name).ToList();
                var autoCompleteSource = new AutoCompleteStringCollection();
                autoCompleteSource.AddRange(PartNames.ToArray());
                comboBox1.AutoCompleteCustomSource = autoCompleteSource;

                comboBox1.Leave += (sender, e) =>
                {
                    string completedText = CompleteText(comboBox1.Text, PartNames);
                    comboBox1.Text = completedText;
                };
            }
            catch { }
        }*/
        public void LoadStorgelistname()
        {
            try
            {
                db = new SyStorgeDataEntities();
                nameS_txt.DataSource = db.STORAGE.Select(x => x.StoreName).ToList();
            }
            catch { }
        }
        public void LoadPartlistname()
        {
            try
            {
                db = new SyStorgeDataEntities();
                comboBox1.DataSource = db.Parts.Where(x => x.storge_id == StrID).Select(x => x.Part_Name).ToList();
            }
            catch { }
        }
        public void LoadItemPartInfo()
        {
            try
            {
                db = new SyStorgeDataEntities();
                txt_all_quantity.Text = db.View.Where(x => x.Id == StrPartID && x.unit_name==cobox_unit.SelectedItem.ToString()).Select(x => x.Total_Parts).FirstOrDefault().ToString();
            }
            catch { }
        }
        
       
        public void SetIDStorgeP()
        {
            try
            {
                db = new SyStorgeDataEntities();
                var id = db.Parts.Where(x => x.Part_Name== comboBox1.SelectedItem.ToString()).Select(x => x.Id).FirstOrDefault();
                StrPartID = id;
                lab_A_A.Text= id.ToString();
                //comboBox2.DataSource = db.Parts.Where(x => x.Id == id).Select(x => x.Unit).ToList();


            }
            catch { }
        }

        public void SetIDStorge()
        {
            try
            {
                db = new SyStorgeDataEntities();
                var id = db.STORAGE.Where(x => x.StoreName == nameS_txt.SelectedItem.ToString()).Select(x => x.Id).FirstOrDefault();
                StrID = id;
                lab_A_S.Text= db.STORAGE.Where(x=>x.Id==id).Select(x => x.KeeperName).FirstOrDefault();
               
            }
            catch { }
        }



        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Type_prices TP = new Type_prices();
            TP.Show();
        }
       
    

        private void btn_addclose_Click(object sender, EventArgs e)
        {
            SaveSanad();
         
           
        }

        public void rep()
        {
            Properties.Settings.Default.IDIncoming = idSelcedt;
            Properties.Settings.Default.Save();
            ReportPrintTool printTool = new ReportPrintTool(new com());
            printTool.AutoShowParametersPanel = false;
            printTool.ShowRibbonPreview();

        }

        public void SaveSanad()
        {
            if (gridView1.RowCount <= 0)
            {
                Message("عذرا لا يمكنك اجراء العملية , السند فارغ", Color.Red);
            }
            else
              if (name_mord.Text == "")
            {
                Message("اكمل الحقل لطفا", Color.Red);
            }
            else
            {
                AddDataAll();
               // InsertDataIntoStorgeAll();
                 rep();
                page.LoadData();
                rep();
                this.Close();
            }
        }
   
        public void AddDataAll ()
        {
            try
            {

                
                db = new SyStorgeDataEntities();

                Incoming v = new Incoming
                {
                    Id = idSelcedt,
                    Id_typ = VTypePID,
                    other_pr = Convert.ToDouble(txt_typprc_2.Text),
                    totle_pice =Convert.ToDouble(get_all_price.Text),
                    totle_pice_min =Convert.ToDouble(mins_all.Text),
                    Supplier_Name = name_mord.Text,
                    Supplier_Entity = entity_mord.Text,
                    State = 1,
                    Incoming_Date = DateTime.Now,

                };
                db.Entry(v).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("ea880811-ab1c-4768-b05f-b7bbd078f2af");

            }
            catch
            {
                Message("خطأ , لطفا تحقق من متطلبات الادخال والاتصال بالسيرفر", Color.Red);

            }
        }
        public void comp_Save()
        {
            // check fields
            int num;
            if (edt_quantity.Text == "" || edt_one_balance.Text == "")
            {
                Message("اكمل الحقل لطفا", Color.Red);
            }
            else if (Convert.ToInt32(edt_quantity.Text)  <= 0 || Convert.ToDouble(edt_one_balance.Text)<=0)
            {
                Message("الحقل الكمية الموردة ,والسعر يجب ان يكون اكبر من الصفر", Color.Red);
            }else if (!int.TryParse(edt_one_balance.Text, out num))
            {
                Message("الحقل السعر يجب ان يكون ارقام فقط", Color.Red);
            }
            else if (nameS_txt.Text=="")
            {
                MessageBox.Show("عذرا لايوجد مخزن");
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("عذرا لايوجد اي صنف في المخزن");
            }
            else if (cobox_unit.Text == "")
            {
                MessageBox.Show("عذرا لايوجد اي وحدة اضف وحدة");
            }

            else
            {
                // Add or edit
                // Add
                comp_AddData();
                LoadData();


            }
        }
        public void comp_ESave()
        {
            int num;
            if ( edt_quantity.Text == "" || edt_one_balance.Text == "")
            {
                Message("اكمل الحقل لطفا", Color.Red);
            }
            else if (Convert.ToInt32(edt_quantity.Text) <= 0 || Convert.ToDouble(edt_one_balance.Text) <= 0)
            {
                Message("الحقل الكمية الموردة ,والسعر يجب ان يكون اكبر من الصفر", Color.Red);
            }
            else if (!int.TryParse(edt_one_balance.Text, out num))
            {
                Message("الحقل السعر يجب ان يكون ارقام فقط", Color.Red);
            }
            else if (nameS_txt.Text == "")
            {
                MessageBox.Show("عذرا لايوجد مخزن");
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("عذرا لايوجد اي صنف في المخزن");
            }
            else if (cobox_unit.Text == "")
            {
                MessageBox.Show("عذرا لايوجد اي وحدة اضف وحدة");
            }

            else
            {


                // Add or edit
                // Add
                comp_EditData();
                LoadData();

            }
        }
        public void comp_AddData()
        {
            try
            {
                db = new SyStorgeDataEntities();
                add = new Compart

                {
                    Id_coms = idSelcedt,
                    Id_part = StrPartID,
                    Id_unit = UntID,
                    Id_typ = TypePID,
                    Add_all = Convert.ToDouble(edt_all_balance.Text),
                    Add_one = Convert.ToDouble(txt_afmns.Text),
                    Other_pri= Convert.ToDouble(txt_typprc.Text),
                    Add_parts = Convert.ToInt16(edt_quantity.Text),
                    price_mins = Convert.ToDouble(txt_minspart.Text),
                 
                    Nots = edt_nots.Text,
                    //  num_vato=edt_vatora.Text,
                    //Num_mars=txt_maras.Text

                };
                db.Entry(add).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                Message("تم اضافة البيانات", Color.Green);

               
            }
            catch
            {
                Message("خطأ , لطفا تحقق من متطلبات الادخال والاتصال بالسيرفر", Color.Red);

            }

        }
        public void comp_EditData()
        {
            try
            {
                db = new SyStorgeDataEntities();
                Compartid = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
                add = new Compart
                {

                    Id = Compartid,
                    Id_part = PartID,
                    Id_unit= UntID,
                    Id_typ = TypePID,
                    Id_coms = idSelcedt,
                    Add_all = Convert.ToDouble(edt_all_balance.Text),
                    Add_one = Convert.ToDouble(txt_afmns.Text),
                    Other_pri = Convert.ToDouble(txt_typprc.Text),
                    Add_parts = Convert.ToInt32(edt_quantity.Text),
                    price_mins = Convert.ToDouble(txt_minspart.Text),
                  
                    Nots =edt_nots.Text,
                    // num_vato = edt_vatora.Text.ToString(),
                    // Num_mars = txt_maras.Text.ToString(),


                };
                db.Entry(add).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                Message("تم تعدبل البيانات", Color.Blue);
                btn_edit.Enabled = false;
                nameS_txt.Enabled = true;
                simpleButton1.Visible = false;
                comboBox1.Enabled = true;
                cobox_unit.Enabled = true;
                btn_add.Enabled = true;
                StrID = (int)xx;
                StrPartID = (int)xx;
                UntID = (int)xx;
                PartID = (int)xx;
                comboBox1.Enabled = true;
                edt_quantity.Text = xx.ToString();
                edt_one_balance.Text = xx.ToString();
                edt_all_balance.Text = xx.ToString();
                edt_nots.Text ="";
            }
            catch
            {
                Message("خطأ , لطفا تحقق من متطلبات الادخال والاتصال بالسيرفر", Color.Red);

            }
        }
        public void btn_add_Click(object sender, EventArgs e)
        {
            
            comp_Save();
        }
        private void Message(string message, Color BackColors)
        {
            txt_message.Visible = true;
            timer1.Enabled = true;
            txt_message.Text = message;
            txt_message.BackColor = BackColors;
          
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_message.Visible = false;
            timer1.Enabled = false;
        }

        public void Form_AddINC_Activated(object sender, EventArgs e)
        {
            LoadUnitslistname();
            LoadStorgelistname();
            LoadPartlistname();
            Getallprice();
            LoadItemPartInfo();
            LoadTypePriceslistname();
            LoadUnitslistname();


        }

        public void nameS_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            SetIDStorge();
            LoadPartlistname();

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetIDStorgeP();
            LoadItemPartInfo();
        }

        public void edt_one_balance_EditValueChanged(object sender, EventArgs e)
        {
            themins();
            if (System.Text.RegularExpressions.Regex.IsMatch(edt_one_balance.Text, "[^0.00-9.00]"))
            {
                MessageBox.Show("الرجاء ادخال قيمة رقمية");
            }
        

        }
        public void edt_quantity_EditValueChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(edt_quantity.Text, "[^0-9]"))
            {
                MessageBox.Show("الرجاء ادخال قيمة رقمية");
                edt_quantity.Text = "1";
            }
            else
            {
                CalcuateTotalPrice();

            }





        }
        public void CalcuateTotalPrice()
        {
            try
            {
                int Quantity = Convert.ToInt32(edt_quantity.Text);
                double UnitPrice = Convert.ToDouble(txt_afmns.Text);
                double TotalPrice = Quantity * UnitPrice;
                edt_all_balance.Text = TotalPrice.ToString("#0.00");
            }
            catch
            {  MessageBox.Show("الرجاء ادخال قيمةرقمية"); }

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            txt_message.Visible = false;
            timer1.Enabled = false;
        }

        public void btn_edit_Click(object sender, EventArgs e)
        {
            nameS_txt.Enabled = true;
            comboBox1.Enabled = true;
            cobox_unit.Enabled = true;
            btn_add.Enabled = true;
            comp_ESave();
        }



        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                db = new SyStorgeDataEntities();
                add = new Compart();
                Compartid = Convert.ToInt16(gridView1.GetFocusedRowCellValue("Id"));
                if (Compartid != 0)
                {
                    var dilogeresult = MessageBox.Show("هل انت متأكد من هذا الاجراء , لا يمكن استرجاع البيانات , سيتم حذف جميع البيانات المرتبطة", "اجراء حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dilogeresult == DialogResult.Yes)
                    {
                        add = db.Compart.Where(x => x.Id == Compartid).FirstOrDefault();
                        db.Entry(add).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        LoadData();

                        if (gridView1.RowCount <= 0)
                        {
                            nameS_txt.Enabled = true;
                        }

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

        private void update_btn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            btn_edit.Enabled = true;
            btn_add.Enabled = false;
            nameS_txt.Enabled=false;
            comboBox1.Enabled = false;
            cobox_unit.Enabled = false;

            
            simpleButton1.Visible = true;

            try
            {
                int v,o = 0;
                db = new SyStorgeDataEntities();
                Compart data = new Compart();
                var ids = Convert.ToInt16(gridView1.GetFocusedRowCellValue("Id"));
                data = db.Compart.Where(x => x.Id == ids).FirstOrDefault();
                PartID =v= (int)data.Id_part;
                UntID=o=(int)data.Id_unit;
                edt_quantity.Text = data.Add_parts.ToString();
                ob = (double)data.Add_one;
                edt_all_balance.Text = data.Add_all.ToString();
                mi = (double)data.price_mins;
                edt_nots.Text = data.Nots;
              //  edt_vatora.Text = data.num_vato.ToString(); 
              //  txt_maras.Text = data.Num_mars.ToString();
              txt_minspart.Text =mi.ToString();
              txt_afmns.Text=  ob.ToString();
              edt_one_balance.Text=(ob+mi).ToString();
            }
            catch {
                Message("الاتوجد بيانات في السند", Color.Red);

            }
        }

        public void Form_AddINC_Load(object sender, EventArgs e)
        {
            try
            {
                if (State_snad != 0&&getform == false)
                {
                    MessageBox.Show("عذرا لقد تم توريد هذا السند مسبقا ", "لا يمكن اجراء العملية", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                 MessageBoxDefaultButton.Button1,
                 MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                 Close();

                }
                else if(State_snad == 0&&getform == true)
                {
                    MessageBox.Show("عذرا لقد لم يتم توريد هذا السند قم باضغظ علئ زر اضافة وارد ", "لا يمكن اجراء العملية", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    Close();
                }
                else
                {

                }
                Getallprice();
                LoadData();
                simpleButton1.Visible = false;
                btn_edit.Enabled = false;
            }
            catch { 
            }
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            nameS_txt.Enabled = true;
            comboBox1.Enabled = true;
            cobox_unit.Enabled = true;
            btn_add.Enabled = true;
            StrID = (int)xx;
            StrPartID= (int)xx;
            UntID = (int)xx;
            PartID = (int)xx;
            comboBox1.Enabled = true;
            edt_quantity.Text = xx.ToString();
            edt_one_balance.Text = xx.ToString();
            edt_all_balance.Text = xx.ToString();
            edt_nots.Text = "";
            simpleButton1.Visible = false;
            btn_edit.Enabled = false;
           

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        public void LoadTypePriceslistname()
        {
            try
            {
                db = new SyStorgeDataEntities();
            
                cbox_typ.DataSource = db.Type_Price.Select(x => x.Name).ToList();
                cbox_typ_2.DataSource = db.Type_Price.Select(x => x.Name).ToList();
            }
            catch { }
        }
        public void SetTyPrInfo()
        {
            try
            {
                db = new SyStorgeDataEntities();
                var id = db.Type_Price.Where(x => x.Name == cbox_typ.SelectedItem.ToString()).Select(x => x.Id).FirstOrDefault();
                TypePID = id;
                var val = db.Type_Price.Where(x => x.Id == id).Select(x => x.Type).FirstOrDefault();
                Double rulit = (double)(Convert.ToDouble(edt_all_balance.Text)/ val);
                txt_typprc.Text= rulit.ToString("#0.00");
            }
            catch { }
        }

        private void cbox_typ_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTyPrInfo();
        }

        private void edt_all_balance_EditValueChanged(object sender, EventArgs e)
        {
            SetTyPrInfo();
        }

        private void txt_minspart_EditValueChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_minspart.Text, @"^\d+(\.\d{1,2})?$"))
            {
                MessageBox.Show("الرجاء إدخال قيمة رقمية صحيحة");
                txt_minspart.Text = "0";
            }
            else {
            if (Double.Parse(txt_minspart.Text) > Double.Parse(edt_one_balance.Text))
            {
                MessageBox.Show("قيمة الخصم اكبر من سعر الحبة");
                txt_minspart.Text = "0";
            }
            else
            {
                themins();
            }
           }


        }

        void themins()
        {

        
  
                    double currentBalance = Convert.ToDouble(edt_one_balance.Text);
                    double minsPart = Convert.ToDouble(txt_minspart.Text);
                    double oldBalance = currentBalance; 

                    if (txt_minspart.Text != "" )
                    {
         
                       
                   
                            currentBalance -= minsPart;
                       
                            
                    }

                    txt_afmns.Text = currentBalance.ToString("#0.00");
                

            
        }

        private void txt_afmins_EditValueChanged(object sender, EventArgs e)
        {
            SetTyPrInfo();
        }


        void Getallprice()
        {
            try
            {
                db = new SyStorgeDataEntities();
                var allP = db.Compart
                    .Where(x => x.Id_coms == idSelcedt)
                    .Select(x => x.Add_all)
                    .DefaultIfEmpty(0) // Handle the case when there are no matching records
                    .Sum();
                gtall = (double)allP;
                get_all_price.Text = gtall.ToString();
            }
            catch { }
        }
        public void LoadUnitslistname()
        {
            try
            {
                db = new SyStorgeDataEntities();
                cobox_unit.DataSource = db.Units.Select(x => x.unit_name).ToList();
            }
            catch { }
        }
        public void SetIDUnits()
        {
            try
            {
                db = new SyStorgeDataEntities();
                var id = db.Units.Where(x => x.unit_name == cobox_unit.SelectedItem.ToString()).Select(x => x.Id).FirstOrDefault();
                UntID = id;
                label20.Text = id.ToString();

            }
            catch { }
        }
        private void cobox_unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadItemPartInfo();
            SetIDUnits();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Unitss U = new Unitss();
            U.Show();
        }


        private void txt_afmns_EditValueChanged(object sender, EventArgs e)
        {
            CalcuateTotalPrice();
        }

        private void txt_typprc_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Form_AddINC_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void txt_all_quantity_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void get_all_price_EditValueChanged(object sender, EventArgs e)
        {
            SetTyVatInfo();
        }

        private void cbox_typ_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTyVatInfo();
        }

        private void txt_typprc_2_EditValueChanged(object sender, EventArgs e)
        {

        }
        public void SetTyVatInfo()
        {
            try
            {
                db = new SyStorgeDataEntities();
                var id = db.Type_Price.Where(x => x.Name == cbox_typ_2.SelectedItem.ToString()).Select(x => x.Id).FirstOrDefault();
                VTypePID = id;
                var val = db.Type_Price.Where(x => x.Id == id).Select(x => x.Type).FirstOrDefault();
                Double rulit = (double)(Convert.ToDouble(get_all_price.Text) / val);
                txt_typprc_2.Text = rulit.ToString("#0.00");
            }
            catch { }
        }
        private void mins_all_EditValueChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(mins_all.Text, @"^\d+(\.\d{1,2})?$"))
            {
                MessageBox.Show("الرجاء إدخال قيمة رقمية صحيحة");
                mins_all.Text = "0.00";
            }
            else
            {
                try
                {
                    double currentBalance = gtall;
                    double minsPart = Convert.ToDouble(mins_all.Text);
                    double oldBalance = currentBalance;

                    if (mins_all.Text != "0" || mins_all.Text != "")
                    {
                        if (minsPart <= currentBalance)
                        {
                            MessageBox.Show("قيمة الخصم اكبر من سعر الكلي");
                            txt_typprc.Text = "0";
                        }
                        else
                        {
                            currentBalance -= minsPart;
                        }
                    }

                    get_all_price.Text = currentBalance.ToString("#0.00");
                }
                catch
                {
        
                }
            }
        }

        private void nameS_txt_TextChanged(object sender, EventArgs e)
        {
          // LoadStorgelistnametxt();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
         //   listPartlistnametxt();
        }
    }
}