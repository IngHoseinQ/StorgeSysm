namespace StorgeSysm.Forms_ui
{
    partial class home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.lb_Time = new DevExpress.XtraEditors.LabelControl();
            this.spas = new DevExpress.XtraEditors.LabelControl();
            this.lb_date = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tarhaal Rounded", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl1.Location = new System.Drawing.Point(605, 324);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(178, 105);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "الرئيسية";
            this.labelControl1.UseMnemonic = false;
            // 
            // lb_Time
            // 
            this.lb_Time.Appearance.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Time.Appearance.Options.UseFont = true;
            this.lb_Time.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_Time.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lb_Time.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.lb_Time.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.lb_Time.Location = new System.Drawing.Point(1218, 0);
            this.lb_Time.Margin = new System.Windows.Forms.Padding(30);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(151, 45);
            this.lb_Time.TabIndex = 1;
            this.lb_Time.Text = "الرئيسية";
            this.lb_Time.UseMnemonic = false;
            // 
            // spas
            // 
            this.spas.Appearance.Font = new System.Drawing.Font("Thabit", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spas.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.spas.Appearance.Options.UseFont = true;
            this.spas.Appearance.Options.UseForeColor = true;
            this.spas.Dock = System.Windows.Forms.DockStyle.Right;
            this.spas.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.spas.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.spas.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.spas.Location = new System.Drawing.Point(1008, 0);
            this.spas.Name = "spas";
            this.spas.Size = new System.Drawing.Size(210, 69);
            this.spas.TabIndex = 2;
            this.spas.Text = "       ";
            this.spas.UseMnemonic = false;
            // 
            // lb_date
            // 
            this.lb_date.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date.Appearance.ForeColor = System.Drawing.Color.Orange;
            this.lb_date.Appearance.Options.UseFont = true;
            this.lb_date.Appearance.Options.UseForeColor = true;
            this.lb_date.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_date.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lb_date.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.lb_date.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.lb_date.Location = new System.Drawing.Point(845, 0);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(163, 48);
            this.lb_date.TabIndex = 3;
            this.lb_date.Text = "الرئيسية";
            this.lb_date.UseMnemonic = false;
            // 
            // home
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.spas);
            this.Controls.Add(this.lb_Time);
            this.Controls.Add(this.labelControl1);
            this.Name = "home";
            this.Size = new System.Drawing.Size(1369, 730);
            this.Load += new System.EventHandler(this.home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl lb_Time;
        private DevExpress.XtraEditors.LabelControl spas;
        private DevExpress.XtraEditors.LabelControl lb_date;
    }
}
