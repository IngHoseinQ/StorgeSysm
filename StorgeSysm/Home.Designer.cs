namespace StorgeSysm
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.Th_change = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemToggleSwitch1 = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.lable = new DevExpress.XtraBars.BarStaticItem();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.Get_name = new DevExpress.XtraBars.BarHeaderItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.repositoryItemToggleSwitch2 = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.th_ch = new DevExpress.XtraBars.BarEditItem();
            this.about_txt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Steng_txt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.User_txt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator3 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlSeparator4 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlSeparator5 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.Out_txt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Come_txt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.Parts_txt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Storg_txt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Home_txt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.xtrahomepage = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.Th_change,
            this.lable,
            this.barToggleSwitchItem1,
            this.Get_name});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemToggleSwitch1,
            this.repositoryItemToggleSwitch2});
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1358, 41);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.barToggleSwitchItem1);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.Get_name);
            // 
            // Th_change
            // 
            this.Th_change.Edit = this.repositoryItemToggleSwitch1;
            this.Th_change.Id = 2;
            this.Th_change.Name = "Th_change";
            // 
            // repositoryItemToggleSwitch1
            // 
            this.repositoryItemToggleSwitch1.AutoHeight = false;
            this.repositoryItemToggleSwitch1.Name = "repositoryItemToggleSwitch1";
            this.repositoryItemToggleSwitch1.OffText = "Off";
            this.repositoryItemToggleSwitch1.OnText = "On";
            // 
            // lable
            // 
            this.lable.Caption = "الوضع المظلم";
            this.lable.Id = 5;
            this.lable.Name = "lable";
            this.lable.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Id = 11;
            this.barToggleSwitchItem1.ImageOptions.SvgImage = global::StorgeSysm.Properties.Resources.weather_sunny;
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            this.barToggleSwitchItem1.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barToggleSwitchItem1_CheckedChanged);
            // 
            // Get_name
            // 
            this.Get_name.Caption = "UserName";
            this.Get_name.Id = 12;
            this.Get_name.Name = "Get_name";
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.Th_change,
            this.lable,
            this.barToggleSwitchItem1,
            this.Get_name});
            this.fluentFormDefaultManager1.MaxItemId = 13;
            this.fluentFormDefaultManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemToggleSwitch1,
            this.repositoryItemToggleSwitch2});
            // 
            // repositoryItemToggleSwitch2
            // 
            this.repositoryItemToggleSwitch2.Name = "repositoryItemToggleSwitch2";
            this.repositoryItemToggleSwitch2.OffText = "Off";
            this.repositoryItemToggleSwitch2.OnText = "On";
            // 
            // th_ch
            // 
            this.th_ch.Caption = "الوضع المظلم";
            this.th_ch.Edit = this.repositoryItemToggleSwitch2;
            this.th_ch.Id = 8;
            this.th_ch.Name = "th_ch";
            this.th_ch.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // about_txt
            // 
            this.about_txt.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.about_txt.Appearance.Default.Options.UseFont = true;
            this.about_txt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("about_txt.ImageOptions.SvgImage")));
            this.about_txt.Name = "about_txt";
            this.about_txt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.about_txt.Text = "عنا";
            this.about_txt.Click += new System.EventHandler(this.about_txt_Click);
            // 
            // Steng_txt
            // 
            this.Steng_txt.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.Steng_txt.Appearance.Default.Options.UseFont = true;
            this.Steng_txt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Steng_txt.ImageOptions.SvgImage")));
            this.Steng_txt.Name = "Steng_txt";
            this.Steng_txt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Steng_txt.Text = "الاعدادات";
            this.Steng_txt.Click += new System.EventHandler(this.Steng_txt_Click);
            // 
            // User_txt
            // 
            this.User_txt.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.User_txt.Appearance.Default.Options.UseFont = true;
            this.User_txt.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlSeparator3,
            this.accordionControlSeparator4,
            this.accordionControlSeparator5});
            this.User_txt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("User_txt.ImageOptions.SvgImage")));
            this.User_txt.Name = "User_txt";
            this.User_txt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.User_txt.Text = "المستخدمون";
            this.User_txt.Click += new System.EventHandler(this.User_txt_Click);
            // 
            // accordionControlSeparator3
            // 
            this.accordionControlSeparator3.Name = "accordionControlSeparator3";
            this.accordionControlSeparator3.Visible = false;
            // 
            // accordionControlSeparator4
            // 
            this.accordionControlSeparator4.Name = "accordionControlSeparator4";
            this.accordionControlSeparator4.Visible = false;
            // 
            // accordionControlSeparator5
            // 
            this.accordionControlSeparator5.Name = "accordionControlSeparator5";
            this.accordionControlSeparator5.Visible = false;
            // 
            // accordionControlSeparator2
            // 
            this.accordionControlSeparator2.Name = "accordionControlSeparator2";
            // 
            // Out_txt
            // 
            this.Out_txt.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.Out_txt.Appearance.Default.Options.UseFont = true;
            this.Out_txt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Out_txt.ImageOptions.SvgImage")));
            this.Out_txt.Name = "Out_txt";
            this.Out_txt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Out_txt.Text = "المنصرف";
            this.Out_txt.Click += new System.EventHandler(this.Out_txt_Click);
            // 
            // Come_txt
            // 
            this.Come_txt.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.Come_txt.Appearance.Default.Options.UseFont = true;
            this.Come_txt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Come_txt.ImageOptions.SvgImage")));
            this.Come_txt.Name = "Come_txt";
            this.Come_txt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Come_txt.Text = "الواردات";
            this.Come_txt.Click += new System.EventHandler(this.Come_txt_Click);
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // Parts_txt
            // 
            this.Parts_txt.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.Parts_txt.Appearance.Default.Options.UseFont = true;
            this.Parts_txt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Parts_txt.ImageOptions.SvgImage")));
            this.Parts_txt.Name = "Parts_txt";
            this.Parts_txt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Parts_txt.Text = "الاصناف";
            this.Parts_txt.Click += new System.EventHandler(this.Parts_txt_Click);
            // 
            // Storg_txt
            // 
            this.Storg_txt.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.Storg_txt.Appearance.Default.Options.UseFont = true;
            this.Storg_txt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Storg_txt.ImageOptions.SvgImage")));
            this.Storg_txt.Name = "Storg_txt";
            this.Storg_txt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Storg_txt.Text = "المخازن";
            this.Storg_txt.Click += new System.EventHandler(this.Storg_txt_Click);
            // 
            // Home_txt
            // 
            this.Home_txt.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_txt.Appearance.Default.Options.UseFont = true;
            this.Home_txt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Home_txt.ImageOptions.SvgImage")));
            this.Home_txt.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.Home_txt.Name = "Home_txt";
            this.Home_txt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Home_txt.Text = "الرئيسية";
            this.Home_txt.Click += new System.EventHandler(this.Home_txt_Click);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.accordionControl1.Appearance.AccordionControl.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.Home_txt,
            this.Storg_txt,
            this.Parts_txt,
            this.accordionControlSeparator1,
            this.Come_txt,
            this.Out_txt,
            this.accordionControlSeparator2,
            this.User_txt,
            this.Steng_txt,
            this.about_txt});
            this.accordionControl1.Location = new System.Drawing.Point(0, 41);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(20163464, 20045780, 20163464, 20045780);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(238, 714);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // xtrahomepage
            // 
            this.xtrahomepage.Margin = new System.Windows.Forms.Padding(291398, 233118, 291398, 233118);
            this.xtrahomepage.Name = "xtrahomepage";
            this.xtrahomepage.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.xtrahomepage.Size = new System.Drawing.Size(1118, 675);
            this.xtrahomepage.Text = "الرئيسية";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.xtraTabControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabControl1.Appearance.Options.UseBackColor = true;
            this.xtraTabControl1.Appearance.Options.UseFont = true;
            this.xtraTabControl1.AppearancePage.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabControl1.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(238, 41);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(364248, 364248, 364248, 364248);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xtraTabControl1.SelectedTabPage = this.xtrahomepage;
            this.xtraTabControl1.Size = new System.Drawing.Size(1120, 714);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtrahomepage});
            this.xtraTabControl1.Transition.AllowTransition = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl1.CloseButtonClick += new System.EventHandler(this.xtraTabControl1_CloseButtonClick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 755);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Home.IconOptions.SvgImage")));
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.Name = "Home";
            this.NavigationControl = this.accordionControl1;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام المخازن";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.BarEditItem Th_change;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryItemToggleSwitch1;
        private DevExpress.XtraBars.BarStaticItem lable;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryItemToggleSwitch2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtrahomepage;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Home_txt;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Storg_txt;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Parts_txt;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Come_txt;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Out_txt;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement User_txt;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator3;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator4;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Steng_txt;
        private DevExpress.XtraBars.Navigation.AccordionControlElement about_txt;
        private DevExpress.XtraBars.BarEditItem th_ch;
        public DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        public DevExpress.XtraBars.BarHeaderItem Get_name;
    }
}