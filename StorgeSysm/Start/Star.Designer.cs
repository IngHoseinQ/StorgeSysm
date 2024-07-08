namespace StorgeSysm.Start
{
    partial class Start
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
            this.progressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.lb_state = new DevExpress.XtraEditors.LabelControl();
            this.peImage = new DevExpress.XtraEditors.PictureEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarControl
            // 
            this.progressBarControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarControl.EditValue = 0;
            this.progressBarControl.Location = new System.Drawing.Point(6, 340);
            this.progressBarControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Properties.ProgressAnimationMode = DevExpress.Utils.Drawing.ProgressAnimationMode.Cycle;
            this.progressBarControl.Size = new System.Drawing.Size(695, 32);
            this.progressBarControl.TabIndex = 5;
            // 
            // lb_state
            // 
            this.lb_state.Appearance.Font = new System.Drawing.Font("TheSans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_state.Appearance.Options.UseFont = true;
            this.lb_state.Location = new System.Drawing.Point(33, 305);
            this.lb_state.Margin = new System.Windows.Forms.Padding(5, 5, 5, 1);
            this.lb_state.Name = "lb_state";
            this.lb_state.Size = new System.Drawing.Size(151, 29);
            this.lb_state.TabIndex = 7;
            this.lb_state.Text = "يرجاء الانتظار  ..^_^..";
            // 
            // peImage
            // 
            this.peImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.peImage.EditValue = global::StorgeSysm.Properties.Resources.bo_audit_changehistory;
            this.peImage.Location = new System.Drawing.Point(1, 1);
            this.peImage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.peImage.Name = "peImage";
            this.peImage.Properties.AllowFocused = false;
            this.peImage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peImage.Properties.Appearance.Options.UseBackColor = true;
            this.peImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peImage.Properties.OptionsEditDialog.OutputImageFormat = DevExpress.XtraEditors.Controls.OutputImageFormat.Original;
            this.peImage.Properties.ShowMenu = false;
            this.peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.peImage.Properties.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.peImage.Properties.ZoomPercent = 300D;
            this.peImage.Size = new System.Drawing.Size(705, 259);
            this.peImage.TabIndex = 9;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 389);
            this.ControlBox = false;
            this.Controls.Add(this.peImage);
            this.Controls.Add(this.lb_state);
            this.Controls.Add(this.progressBarControl);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IconOptions.SvgImage = global::StorgeSysm.Properties.Resources.bo_audit_changehistory;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Start";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مرحبااا";
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarControl;
        private DevExpress.XtraEditors.LabelControl lb_state;
        private DevExpress.XtraEditors.PictureEdit peImage;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}
