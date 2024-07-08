namespace StorgeSysm.Forms_ui
{
    partial class sttings
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
            this.btn_open_tps = new DevExpress.XtraEditors.SimpleButton();
            this.btn_open_uns = new DevExpress.XtraEditors.SimpleButton();
            this.db_btn = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btn_open_tps
            // 
            this.btn_open_tps.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_open_tps.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open_tps.Appearance.Options.UseFont = true;
            this.btn_open_tps.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_open_tps.ImageOptions.SvgImage = global::StorgeSysm.Properties.Resources.currency;
            this.btn_open_tps.Location = new System.Drawing.Point(637, 109);
            this.btn_open_tps.Name = "btn_open_tps";
            this.btn_open_tps.Size = new System.Drawing.Size(228, 84);
            this.btn_open_tps.TabIndex = 3;
            this.btn_open_tps.Text = "اعدادات العملات";
            this.btn_open_tps.Click += new System.EventHandler(this.btn_open_tps_Click);
            // 
            // btn_open_uns
            // 
            this.btn_open_uns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_open_uns.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open_uns.Appearance.Options.UseFont = true;
            this.btn_open_uns.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_open_uns.ImageOptions.SvgImage = global::StorgeSysm.Properties.Resources.grouplabels;
            this.btn_open_uns.Location = new System.Drawing.Point(176, 109);
            this.btn_open_uns.Name = "btn_open_uns";
            this.btn_open_uns.Size = new System.Drawing.Size(228, 84);
            this.btn_open_uns.TabIndex = 4;
            this.btn_open_uns.Text = "اعدادات الاصناف";
            this.btn_open_uns.Click += new System.EventHandler(this.btn_open_uns_Click);
            // 
            // db_btn
            // 
            this.db_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.db_btn.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_btn.Appearance.Options.UseFont = true;
            this.db_btn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.db_btn.ImageOptions.SvgImage = global::StorgeSysm.Properties.Resources.managedatasource;
            this.db_btn.Location = new System.Drawing.Point(371, 325);
            this.db_btn.Name = "db_btn";
            this.db_btn.Size = new System.Drawing.Size(252, 84);
            this.db_btn.TabIndex = 5;
            this.db_btn.Text = "اعدادات الاتصال وقاعدة البيانات";
            this.db_btn.Click += new System.EventHandler(this.db_btn_Click);
            // 
            // sttings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.db_btn);
            this.Controls.Add(this.btn_open_uns);
            this.Controls.Add(this.btn_open_tps);
            this.Name = "sttings";
            this.Size = new System.Drawing.Size(1017, 611);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_open_tps;
        private DevExpress.XtraEditors.SimpleButton btn_open_uns;
        private DevExpress.XtraEditors.SimpleButton db_btn;
    }
}
