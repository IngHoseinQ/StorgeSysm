namespace StorgeSysm.Frm_addS
{
    partial class Form_AddP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddP));
            this.txt_message = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_addclose = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.NameS = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.link_addnewgroups = new System.Windows.Forms.LinkLabel();
            this.edt_name_p = new DevExpress.XtraEditors.TextEdit();
            this.comboBox_s = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_name_p.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_message
            // 
            this.txt_message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_message.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_message.ForeColor = System.Drawing.Color.White;
            this.txt_message.Location = new System.Drawing.Point(0, 319);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(579, 52);
            this.txt_message.TabIndex = 17;
            this.txt_message.Text = "رسالة";
            this.txt_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_message.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_addclose);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 59);
            this.panel1.TabIndex = 15;
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
            this.btn_add.Location = new System.Drawing.Point(402, 5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(167, 47);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // NameS
            // 
            this.NameS.AutoSize = true;
            this.NameS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameS.ForeColor = System.Drawing.Color.DimGray;
            this.NameS.Location = new System.Drawing.Point(233, 13);
            this.NameS.Name = "NameS";
            this.NameS.Size = new System.Drawing.Size(101, 29);
            this.NameS.TabIndex = 11;
            this.NameS.Text = "اسم القطعة";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(249, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "المخزن";
            // 
            // link_addnewgroups
            // 
            this.link_addnewgroups.AutoSize = true;
            this.link_addnewgroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_addnewgroups.LinkColor = System.Drawing.Color.Goldenrod;
            this.link_addnewgroups.Location = new System.Drawing.Point(446, 207);
            this.link_addnewgroups.Name = "link_addnewgroups";
            this.link_addnewgroups.Size = new System.Drawing.Size(46, 25);
            this.link_addnewgroups.TabIndex = 23;
            this.link_addnewgroups.TabStop = true;
            this.link_addnewgroups.Text = "جديد";
            this.link_addnewgroups.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_addnewgroups_LinkClicked);
            // 
            // edt_name_p
            // 
            this.edt_name_p.Location = new System.Drawing.Point(40, 69);
            this.edt_name_p.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edt_name_p.Name = "edt_name_p";
            this.edt_name_p.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.edt_name_p.Properties.Appearance.Options.UseFont = true;
            this.edt_name_p.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_name_p.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_name_p.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_name_p.Size = new System.Drawing.Size(474, 48);
            this.edt_name_p.TabIndex = 71;
            // 
            // comboBox_s
            // 
            this.comboBox_s.Animated = true;
            this.comboBox_s.AutoRoundedCorners = true;
            this.comboBox_s.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_s.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox_s.BorderRadius = 17;
            this.comboBox_s.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_s.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_s.FocusedColor = System.Drawing.Color.Empty;
            this.comboBox_s.FocusedState.Parent = this.comboBox_s;
            this.comboBox_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_s.ForeColor = System.Drawing.Color.Black;
            this.comboBox_s.FormattingEnabled = true;
            this.comboBox_s.HoverState.Parent = this.comboBox_s;
            this.comboBox_s.IntegralHeight = false;
            this.comboBox_s.ItemHeight = 30;
            this.comboBox_s.ItemsAppearance.Parent = this.comboBox_s;
            this.comboBox_s.Location = new System.Drawing.Point(40, 235);
            this.comboBox_s.Name = "comboBox_s";
            this.comboBox_s.ShadowDecoration.Parent = this.comboBox_s;
            this.comboBox_s.Size = new System.Drawing.Size(474, 36);
            this.comboBox_s.TabIndex = 78;
            this.comboBox_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.comboBox_s.SelectedIndexChanged += new System.EventHandler(this.comboBox_s_SelectedIndexChanged_1);
            // 
            // Form_AddP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 430);
            this.Controls.Add(this.comboBox_s);
            this.Controls.Add(this.edt_name_p);
            this.Controls.Add(this.link_addnewgroups);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NameS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Form_AddP.IconOptions.SvgImage")));
            this.Name = "Form_AddP";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "القطع";
            this.Activated += new System.EventHandler(this.Form_AddP_Activated);
            this.Load += new System.EventHandler(this.Form_AddP_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_name_p.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt_message;
        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.SimpleButton btn_addclose;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.Label NameS;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel link_addnewgroups;
        public DevExpress.XtraEditors.TextEdit edt_name_p;
        public Guna.UI2.WinForms.Guna2ComboBox comboBox_s;
    }
}