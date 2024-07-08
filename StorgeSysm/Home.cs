
using DevExpress.XtraBars;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using StorgeSysm.Forms_ui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorgeSysm
{
    public partial class Home : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public bool w;
        bool PageStageClose;
        XtraTabPage XtraPage;
        public Home()
        {

            InitializeComponent();
            LoadHomePage();
        }

        private void Home_txt_Click(object sender, EventArgs e)
        {
            LoadHomePage();
        }
        private void SelectPage(DevExpress.XtraEditors.XtraUserControl control, string PageTitle)
        {
            try
            {
                foreach (XtraTabPage pageindex in xtraTabControl1.TabPages)
                {
                    if (pageindex.Text == PageTitle)
                    {
                        PageStageClose = false;
                        XtraPage = pageindex;
                        break;

                    }
                    else
                    {
                        PageStageClose = true;
                    }
                }
                if (PageStageClose == true)
                {
                    control.Dock = DockStyle.Fill;
                    xtraTabControl1.TabPages.Add();
                    var CurrentPage = xtraTabControl1.TabPages.Last();
                    xtraTabControl1.SelectedTabPage = CurrentPage;
                    CurrentPage.Text = PageTitle;
                    CurrentPage.Controls.Add(control);
                }
                else
                {
                    xtraTabControl1.SelectedTabPage = XtraPage;
                }
            }
            catch { }

        }
        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            var xtrapage = arg.Page as XtraTabPage;
            xtraTabControl1.TabPages.Remove(xtrapage);
        }

        private void LoadHomePage()
        {
            try
            {
                home page = new home();
                page.Dock = DockStyle.Fill;
                xtrahomepage.Controls.Clear();
                xtrahomepage.Controls.Add(page);
                xtraTabControl1.ClosePageButtonShowMode.Equals(false);
                xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages.First();
            }
            catch { }


        }


        private void Storg_txt_Click(object sender, EventArgs e)
        {
            storge page = new storge();

            SelectPage(page, "المخازن");
        }



        private void FDFormC_Click(object sender, EventArgs e)
        {

        }

        private void Parts_txt_Click(object sender, EventArgs e)
        {
            colect_part page = new colect_part();

            SelectPage(page, "الاصناف");
        }

        private void Come_txt_Click(object sender, EventArgs e)
        {
            incoming page = new incoming();

            SelectPage(page, "الواردت");
        }


        public void barEditItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {


        }






        public void Home_Load(object sender, EventArgs e)
        {
            w = Properties.Settings.Default.state;
            if (w == false)
            {

                barToggleSwitchItem1.ImageOptions.SvgImage = Properties.Resources.weather_sunny;
                barToggleSwitchItem1.Checked = true;

            }
            else
            {
                barToggleSwitchItem1.ImageOptions.SvgImage = Properties.Resources.weather_moon;

                barToggleSwitchItem1.Checked = false;
            }

        }


        public void barToggleSwitchItem1_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (barToggleSwitchItem1.Checked == true)
            {

                barToggleSwitchItem1.ImageOptions.SvgImage = Properties.Resources.weather_sunny;
                Properties.Settings.Default.state = false;
                Properties.Settings.Default.Save();
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(DevExpress.LookAndFeel.SkinSvgPalette.WXI.Darkness);

            }
            else
            {
                barToggleSwitchItem1.ImageOptions.SvgImage = Properties.Resources.weather_moon;
                Properties.Settings.Default.state = true;
                Properties.Settings.Default.Save();
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(DevExpress.LookAndFeel.SkinSvgPalette.WXI);
            }
        }

        private void User_txt_Click(object sender, EventArgs e)
        {
            users page = new users();

            SelectPage(page, "المستخدمون");
        }

        private void Out_txt_Click(object sender, EventArgs e)
        {
            outsale page = new outsale();

            SelectPage(page, "المصروف");
        }

        private void about_txt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hossein Ahmed Qasspa");
        }



        private void Steng_txt_Click(object sender, EventArgs e)
        {
            sttings page = new sttings();

            SelectPage(page, "لاعدادات");
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {

            var dilogeresult = MessageBox.Show("هل انت متأكد من عملية الخروج ,من النظام", "تسجيل الخروج", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dilogeresult == DialogResult.OK)
            {

                Application.Exit();

            }else
            if(dilogeresult == DialogResult.Cancel || dilogeresult == DialogResult.None)
            {
               
                e.Cancel = true;

            }

        }
    }

}
