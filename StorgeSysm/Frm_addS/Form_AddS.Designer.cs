namespace StorgeSysm.Frm_addS
{
    partial class Form_AddS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddS));
            this.edt_name_s = new System.Windows.Forms.TextBox();
            this.NameS = new System.Windows.Forms.Label();
            this.edt_name_as = new System.Windows.Forms.TextBox();
            this.NameAS = new System.Windows.Forms.Label();
            this.edt_name_ds = new System.Windows.Forms.RichTextBox();
            this.txt_message = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_addclose = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // edt_name_s
            // 
            this.edt_name_s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edt_name_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_name_s.Location = new System.Drawing.Point(67, 75);
            this.edt_name_s.Name = "edt_name_s";
            this.edt_name_s.Size = new System.Drawing.Size(474, 34);
            this.edt_name_s.TabIndex = 4;
            this.edt_name_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameS
            // 
            this.NameS.AutoSize = true;
            this.NameS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameS.ForeColor = System.Drawing.Color.DimGray;
            this.NameS.Location = new System.Drawing.Point(238, 36);
            this.NameS.Name = "NameS";
            this.NameS.Size = new System.Drawing.Size(108, 29);
            this.NameS.TabIndex = 3;
            this.NameS.Text = "اسم المخزن";
            // 
            // edt_name_as
            // 
            this.edt_name_as.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edt_name_as.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_name_as.Location = new System.Drawing.Point(67, 165);
            this.edt_name_as.Name = "edt_name_as";
            this.edt_name_as.Size = new System.Drawing.Size(474, 34);
            this.edt_name_as.TabIndex = 6;
            this.edt_name_as.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameAS
            // 
            this.NameAS.AutoSize = true;
            this.NameAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameAS.ForeColor = System.Drawing.Color.DimGray;
            this.NameAS.Location = new System.Drawing.Point(239, 122);
            this.NameAS.Name = "NameAS";
            this.NameAS.Size = new System.Drawing.Size(116, 29);
            this.NameAS.TabIndex = 5;
            this.NameAS.Text = "امين المخزن";
            // 
            // edt_name_ds
            // 
            this.edt_name_ds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edt_name_ds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_name_ds.Location = new System.Drawing.Point(65, 267);
            this.edt_name_ds.Name = "edt_name_ds";
            this.edt_name_ds.Size = new System.Drawing.Size(474, 202);
            this.edt_name_ds.TabIndex = 10;
            this.edt_name_ds.Text = "";
            // 
            // txt_message
            // 
            this.txt_message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_message.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_message.ForeColor = System.Drawing.Color.White;
            this.txt_message.Location = new System.Drawing.Point(0, 501);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(583, 52);
            this.txt_message.TabIndex = 9;
            this.txt_message.Text = "رسالة";
            this.txt_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_message.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(262, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "الوصف";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_addclose);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 553);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 59);
            this.panel1.TabIndex = 7;
            // 
            // btn_addclose
            // 
            this.btn_addclose.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_addclose.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addclose.Appearance.Options.UseFont = true;
            this.btn_addclose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_addclose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_addclose.ImageOptions.SvgImage")));
            this.btn_addclose.Location = new System.Drawing.Point(6, 5);
            this.btn_addclose.Name = "btn_addclose";
            this.btn_addclose.Size = new System.Drawing.Size(167, 47);
            this.btn_addclose.TabIndex = 1;
            this.btn_addclose.Text = "اضافة+ غلق";
            this.btn_addclose.Click += new System.EventHandler(this.btn_addclose_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_add.ImageOptions.SvgImage")));
            this.btn_add.Location = new System.Drawing.Point(406, 5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(167, 47);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "68482cd8-0ea5-4b95-ac10-8ddabafc16d9";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("8c9a37c5-3ccb-4827-8b52-1efc3cbe49d6", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "تمت عملية التعديل بنجاح", "تمت عملية التعديل بنجاح", "تمت عملية التعديل بنجاح", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("ea880811-ab1c-4768-b05f-b7bbd078f2af", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications1"))), "تمت الاضافة بنجاح", "تمت الاضافة بنجاح", "تمت الاضافة بنجاح", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // Form_AddS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 612);
            this.Controls.Add(this.edt_name_ds);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.edt_name_as);
            this.Controls.Add(this.NameAS);
            this.Controls.Add(this.edt_name_s);
            this.Controls.Add(this.NameS);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Form_AddS.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AddS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مخزن";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox edt_name_s;
        private System.Windows.Forms.Label NameS;
        public System.Windows.Forms.TextBox edt_name_as;
        private System.Windows.Forms.Label NameAS;
        public System.Windows.Forms.RichTextBox edt_name_ds;
        private System.Windows.Forms.Label txt_message;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.SimpleButton btn_addclose;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
    }
}