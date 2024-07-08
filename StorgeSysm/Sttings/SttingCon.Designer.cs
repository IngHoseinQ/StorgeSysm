namespace StorgeSysm.Sttings
{
    partial class SttingCon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SttingCon));
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.group_server = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_database_name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_user_server_pass = new System.Windows.Forms.TextBox();
            this.txt_server_user_name = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_server = new System.Windows.Forms.TextBox();
            this.rdb_inter = new System.Windows.Forms.RadioButton();
            this.rdb_local = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_backup = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.group_server.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(318, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "اعدادات قاعدة البيانات";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.group_server);
            this.groupBox1.Controls.Add(this.rdb_inter);
            this.groupBox1.Controls.Add(this.rdb_local);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(848, 383);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اعدادت الاتصال";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButton2.Location = new System.Drawing.Point(316, 328);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(167, 50);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "حفظ";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // group_server
            // 
            this.group_server.Controls.Add(this.label13);
            this.group_server.Controls.Add(this.txt_database_name);
            this.group_server.Controls.Add(this.label11);
            this.group_server.Controls.Add(this.label10);
            this.group_server.Controls.Add(this.label9);
            this.group_server.Controls.Add(this.label8);
            this.group_server.Controls.Add(this.txt_user_server_pass);
            this.group_server.Controls.Add(this.txt_server_user_name);
            this.group_server.Controls.Add(this.txt_port);
            this.group_server.Controls.Add(this.txt_server);
            this.group_server.Enabled = false;
            this.group_server.Location = new System.Drawing.Point(14, 17);
            this.group_server.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_server.Name = "group_server";
            this.group_server.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.group_server.Size = new System.Drawing.Size(668, 306);
            this.group_server.TabIndex = 1;
            this.group_server.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(522, 140);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "اسم قاعده البيانات";
            // 
            // txt_database_name
            // 
            this.txt_database_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_database_name.Location = new System.Drawing.Point(38, 132);
            this.txt_database_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_database_name.Multiline = true;
            this.txt_database_name.Name = "txt_database_name";
            this.txt_database_name.Size = new System.Drawing.Size(426, 42);
            this.txt_database_name.TabIndex = 9;
            this.txt_database_name.Text = "SyStorgeData";
            this.txt_database_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(576, 256);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "كلمة السر";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(551, 209);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "اسم المستخدم";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(568, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "رقم المنفذ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(510, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "اسم السيرفر الكامل";
            // 
            // txt_user_server_pass
            // 
            this.txt_user_server_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_server_pass.Location = new System.Drawing.Point(31, 250);
            this.txt_user_server_pass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_user_server_pass.Name = "txt_user_server_pass";
            this.txt_user_server_pass.Size = new System.Drawing.Size(443, 30);
            this.txt_user_server_pass.TabIndex = 7;
            this.txt_user_server_pass.Text = "admin";
            this.txt_user_server_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_server_user_name
            // 
            this.txt_server_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_server_user_name.Location = new System.Drawing.Point(42, 195);
            this.txt_server_user_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_server_user_name.Multiline = true;
            this.txt_server_user_name.Name = "txt_server_user_name";
            this.txt_server_user_name.Size = new System.Drawing.Size(426, 42);
            this.txt_server_user_name.TabIndex = 7;
            this.txt_server_user_name.Text = "admin";
            this.txt_server_user_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_port
            // 
            this.txt_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_port.Location = new System.Drawing.Point(26, 78);
            this.txt_port.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(443, 30);
            this.txt_port.TabIndex = 7;
            this.txt_port.Text = "1433";
            this.txt_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_server
            // 
            this.txt_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_server.Location = new System.Drawing.Point(26, 25);
            this.txt_server.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(443, 30);
            this.txt_server.TabIndex = 7;
            this.txt_server.Text = "hostname\\SQLEXPRESS";
            this.txt_server.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdb_inter
            // 
            this.rdb_inter.AutoSize = true;
            this.rdb_inter.Location = new System.Drawing.Point(732, 141);
            this.rdb_inter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdb_inter.Name = "rdb_inter";
            this.rdb_inter.Size = new System.Drawing.Size(73, 29);
            this.rdb_inter.TabIndex = 0;
            this.rdb_inter.Text = "شبكي";
            this.rdb_inter.UseVisualStyleBackColor = true;
            this.rdb_inter.CheckedChanged += new System.EventHandler(this.rdb_inter_CheckedChanged);
            // 
            // rdb_local
            // 
            this.rdb_local.AutoSize = true;
            this.rdb_local.Checked = true;
            this.rdb_local.Location = new System.Drawing.Point(732, 60);
            this.rdb_local.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdb_local.Name = "rdb_local";
            this.rdb_local.Size = new System.Drawing.Size(72, 29);
            this.rdb_local.TabIndex = 0;
            this.rdb_local.TabStop = true;
            this.rdb_local.Text = "محلي";
            this.rdb_local.UseVisualStyleBackColor = true;
            this.rdb_local.CheckedChanged += new System.EventHandler(this.rdb_local_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.simpleButton3);
            this.groupBox3.Controls.Add(this.btn_backup);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(16, 449);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(848, 146);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "اعدادات النسخ الاحتياطي والتعيين";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButton3.Location = new System.Drawing.Point(40, 54);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(370, 68);
            this.simpleButton3.TabIndex = 5;
            this.simpleButton3.Text = "استعادة نسخة احتياطية";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btn_backup
            // 
            this.btn_backup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_backup.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backup.Appearance.Options.UseFont = true;
            this.btn_backup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_backup.ImageOptions.Image")));
            this.btn_backup.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_backup.Location = new System.Drawing.Point(457, 54);
            this.btn_backup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(370, 68);
            this.btn_backup.TabIndex = 5;
            this.btn_backup.Text = "اخذ نسخة احتياطية";
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // SttingCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 605);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Name = "SttingCon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SttingCon";
            this.Load += new System.EventHandler(this.SttingCon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.group_server.ResumeLayout(false);
            this.group_server.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.GroupBox group_server;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_database_name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_user_server_pass;
        private System.Windows.Forms.TextBox txt_server_user_name;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.RadioButton rdb_inter;
        private System.Windows.Forms.RadioButton rdb_local;
        private System.Windows.Forms.GroupBox groupBox3;
        public DevExpress.XtraEditors.SimpleButton simpleButton3;
        public DevExpress.XtraEditors.SimpleButton btn_backup;
    }
}