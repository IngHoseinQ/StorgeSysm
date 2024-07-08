namespace StorgeSysm.Start
{
    partial class Chose
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.db_btn = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(121, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(417, 34);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "قم بختيار العملية التي ترغب بها";
            // 
            // db_btn
            // 
            this.db_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.db_btn.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_btn.Appearance.Options.UseFont = true;
            this.db_btn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.db_btn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.db_btn.ImageOptions.SvgImage = global::StorgeSysm.Properties.Resources.managedatasource;
            this.db_btn.Location = new System.Drawing.Point(36, 100);
            this.db_btn.Name = "db_btn";
            this.db_btn.Size = new System.Drawing.Size(252, 180);
            this.db_btn.TabIndex = 6;
            this.db_btn.Text = "استعادة نسخة احتياطية \r\nمن قاعدة البيانات";
            this.db_btn.Click += new System.EventHandler(this.db_btn_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton1.ImageOptions.SvgImage = global::StorgeSysm.Properties.Resources.newproduct;
            this.simpleButton1.Location = new System.Drawing.Point(372, 100);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(252, 180);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "انشاء حساب جديد والبدئ \r\nبستخدام النظام";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Chose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 315);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.db_btn);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton db_btn;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}