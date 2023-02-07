using Nhom5.Utility;
using Nhom5.View.hokhau_nhankhau.hokhau_function;
using Nhom5.View.hokhau_nhankhau.nhankhau_function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom5.View.hokhau_nhankhau
{
    public partial class HoKhauUC : UserControl
    {
        public HoKhauUC()
        {
            InitializeComponent();
            featureSearchBox.SelectedIndex = 0;
        }
        private void HoKhauUC_VisibleChanged(object sender, EventArgs e)
        {
            AutoChangeColor.changeColorScreen2(sender, e, new List<String>() { "Button" });
            AutoChangeColor.changeSPanelScreen2(sender, searchSPanel);
            AutoChangeColor.changeSPanelScreen2(sender, reLoadSPanel);
        }

        private void HoKhauUC_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void themMoiBtn_Click(object sender, EventArgs e)
        {
            var startScreenForm = this.Parent as SecondScreen;
            ThemMoiHoKhau themMoiScreen = new ThemMoiHoKhau();
            themMoiScreen.getFormRef(startScreenForm);
            OpenScreen.openAnotherScreen(startScreenForm, themMoiScreen, 1);
        }

        private void xemChiTietBtn_Click(object sender, EventArgs e)
        {
            var startScreenForm = this.Parent as SecondScreen;
            XemHoKhau xemHoKhauScreen = new XemHoKhau();
            xemHoKhauScreen.getFormRef(startScreenForm);
            OpenScreen.openAnotherScreen(startScreenForm, xemHoKhauScreen, 1);
        }

        private void chinhSuaBtn_Click(object sender, EventArgs e)
        {
            var startScreenForm = this.Parent as SecondScreen;
            ChinhSuaHoKhau chinhSuaHoKhauScreen = new ChinhSuaHoKhau();
            chinhSuaHoKhauScreen.getFormRef(startScreenForm);
            OpenScreen.openAnotherScreen(startScreenForm, chinhSuaHoKhauScreen, 1);
        }

        private void tachHoKhauBtn_Click(object sender, EventArgs e)
        {
            var startScreenForm = this.Parent as SecondScreen;
            TachHoKhau tachHoKhauScreen = new TachHoKhau();
            tachHoKhauScreen.getFormRef(startScreenForm);
            OpenScreen.openAnotherScreen(startScreenForm, tachHoKhauScreen, 1);
        }
        #region SPanel click
        private void searchSPanel_Click(object sender, EventArgs e)
        {
            Console.WriteLine("click");
        }

        private void searchPic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            SPanel sPanel = pic.Parent as SPanel;
            searchSPanel_Click(sPanel, e);
        }
        private void reLoadSPanel_Click(object sender, EventArgs e)
        {
            Console.WriteLine("click");
        }

        private void reLoadPic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            SPanel sPanel = pic.Parent as SPanel;
            reLoadSPanel_Click(sPanel, e);
        }
        #endregion


    }
}
