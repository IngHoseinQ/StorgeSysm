using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StorgeSysm.Properties;
using System.Reflection;
using System.Diagnostics;

namespace StorgeSysm.Sttings
{
    public partial class SttingCon : DevExpress.XtraEditors.XtraForm
    {
        public bool isFrist;
        //string connect_str = "";
        //string server_name = @".\sqlexpress";
        public SttingCon()
        {
            InitializeComponent();
            get_server_info();
        }
        void get_server_info()
        {
            string server_name;
            server_name = StorgeSysm.Properties.Settings.Default.server_name;
           String porst = StorgeSysm.Properties.Settings.Default.port;
            String database = StorgeSysm.Properties.Settings.Default.database_name;
            String user_server = StorgeSysm.Properties.Settings.Default.user_server_id;
            String pass_user_server = StorgeSysm.Properties.Settings.Default.user_server_pass;
            if (server_name != "")
            {
                txt_server.Text = server_name;
            }
            if (porst != "")
            {
                txt_port.Text = porst;
            }
            if (user_server != "")
            {
                txt_server_user_name.Text = user_server;
            }
            if (database != "")
            {
                txt_database_name.Text = database;
            }
            if (pass_user_server != "")
            {
                txt_user_server_pass.Text = pass_user_server;
            }
        }
        void sav_server()
        {
            string temp_connt = "";
            var server_name = txt_server.Text;
            var database = txt_database_name.Text;
            var porst = txt_port.Text;
            var user_server = txt_server_user_name.Text;
            var pass_user_server = txt_user_server_pass.Text;
            const string qu = "\"";
            if (rdb_local.Checked)
            {
                var conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                temp_connt = conf.ConnectionStrings.ConnectionStrings["SyStorgeDataEntities"].ConnectionString.ToString();
                var connect_strring = @"metadata=res://*/Model.csdl|res://*/Model.ssdl|res://*/Model.msl;provider=System.Data.SqlClient;provider connection string=" + qu + ";data source=" + server_name + ";initial catalog="+ database + ";integrated security=True;multipleactiveresultsets=True;application name=EntityFramework" + qu + ";";
                conf.ConnectionStrings.ConnectionStrings["SyStorgeDataEntities"].ConnectionString = connect_strring;
                conf.Save();
                ConfigurationManager.RefreshSection("connectionString");
                var str = conf.ConnectionStrings.ConnectionStrings["SyStorgeDataEntities"].ConnectionString;
                MessageBox.Show(str);
                StorgeSysm.Properties.Settings.Default.server_name = server_name;
                StorgeSysm.Properties.Settings.Default.port = porst;
                StorgeSysm.Properties.Settings.Default.database_name = database;
                StorgeSysm.Properties.Settings.Default.user_server_id = user_server;
                StorgeSysm.Properties.Settings.Default.user_server_pass = pass_user_server;
                StorgeSysm.Properties.Settings.Default.Save();


            }
            else
            {
                var conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                temp_connt = conf.ConnectionStrings.ConnectionStrings["SyStorgeDataEntities"].ConnectionString.ToString();
                var connect_strring = @"metadata=res://*/Model.csdl|res://*/Model.ssdl|res://*/Model.msl;provider=System.Data.SqlClient;provider connection string=';data source=" + server_name + "," + porst + ";initial catalog=" + database + ";User ID=" + user_server + ";Password=" + pass_user_server + "; connect Timeout=60;multipleactiveresultsets=True;application name=EntityFramework';";
                conf.ConnectionStrings.ConnectionStrings["SyStorgeDataEntities"].ConnectionString = connect_strring;
                conf.Save();
                ConfigurationManager.RefreshSection("connectionString");
                var str = conf.ConnectionStrings.ConnectionStrings["SyStorgeDataEntities"].ConnectionString;
                MessageBox.Show(str);
                StorgeSysm.Properties.Settings.Default.server_name = server_name;
                StorgeSysm.Properties.Settings.Default.port = porst;
                StorgeSysm.Properties.Settings.Default.database_name = database;
                StorgeSysm.Properties.Settings.Default.user_server_id = user_server;
                StorgeSysm.Properties.Settings.Default.user_server_pass = pass_user_server;
                StorgeSysm.Properties.Settings.Default.Save();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("يجب عليك اعادة تشغيل النظام لحفظ البيانات ", "ضبط اعدادات الاتصال ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {

                sav_server();
                String appPath = Assembly.GetEntryAssembly().Location;
                Process.Start(appPath);
                Environment.Exit(0);
            }
         

        }

        private void rdb_inter_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_inter.Checked)
            {
                group_server.Enabled = true;
                txt_server_user_name.Enabled = true;
                txt_user_server_pass.Enabled = true;
                txt_port.Enabled = true;
            }
        }

        private void rdb_local_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_local.Checked)
            {
                group_server.Enabled = true;
                txt_server_user_name.Enabled = false;
                txt_user_server_pass.Enabled = false;
                txt_port.Enabled = false;
            }

        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                var rs = folder.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    SyStorgeDataEntities db = new SyStorgeDataEntities();
                    string dbname = db.Database.Connection.Database;
                    string dbBackUp = "SyStorgeData" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm");
                    var fullpath = folder.SelectedPath + "\\" + dbBackUp + ".bak";
                    string sqlCommand = @"BACKUP DATABASE [{0}] TO DISK = '{1}' WITH NOFORMAT, NOINIT, NAME = N'{2}', SKIP, NOREWIND, NOUNLOAD, STATS = 10";
                    int path = db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand, dbname, fullpath, dbBackUp));
                    MessageBox.Show("تم النسخ الاحتياطي بنجاح");
                  
                }
            }
            catch
            {
                MessageBox.Show("خطأ، لا يمكن النسخ الاحتياطي إلى المسار المحدد. الرجاء تحديد مسار مختلف. تذكر ألا تحدد القرص C");
            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog folder = new OpenFileDialog();
                var rs = folder.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    SyStorgeDataEntities db = new SyStorgeDataEntities();

                    string dbname = db.Database.Connection.Database;
                    string dbBackUp = "SyStorgeData" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm");
                    // MessageBox.Show(folder.FileName);
                    string sqlCommand = @"USE master; RESTORE DATABASE [{0}] FROM DISK = '" + folder.FileName + "' WITH REPLACE";
                    int path = db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand, dbname));
                    MessageBox.Show("تم استعادة النسخة الاحتياطية بنجاح");
                    if (isFrist == true)
                    {
                        var dilogeresult = MessageBox.Show("  يجب اعادة تشغبل النظام ليتم حفظ التغيرات اضغط نعم", "اعادة تشغبل", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dilogeresult == DialogResult.Yes)
                        {
                            String appPath = Assembly.GetEntryAssembly().Location;
                            Process.Start(appPath);
                            Environment.Exit(0);
                        }
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("لا يمكن استعادة النسخة الاحتياطية, يرجى التأكد من الملف المختار" + ex.Message.ToString() + "تاكد من اغلاق جميع عمليات قاعدة البيانات ثم اعد المحاولة ");
            }
        }

        private void SttingCon_Load(object sender, EventArgs e)
        {
            get_server_info();
            if (rdb_local.Checked)
            {
                group_server.Enabled = true;
                txt_server_user_name.Enabled = false;
                txt_user_server_pass.Enabled = false;
                txt_port.Enabled = false;
            }
        }
    }
    
    
}