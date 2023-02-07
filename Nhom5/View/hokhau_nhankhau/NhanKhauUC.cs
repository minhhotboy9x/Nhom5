using Nhom5.Utility;
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
    public partial class NhanKhauUC : UserControl
    {
        public NhanKhauUC()
        {
            InitializeComponent();
            featureSearchBox.SelectedIndex = 0;
        }
        #region change sPanel Color
        public void NhanKhauUC_VisibleChanged(object sender, EventArgs e)
        {
            AutoChangeColor.changeColorScreen2(sender, e, new List<String>() {"Button"});
            AutoChangeColor.changeSPanelScreen2(sender, searchSPanel);
            AutoChangeColor.changeSPanelScreen2(sender, reLoadSPanel);
        }
        private void themMoiBtn_EnabledChanged(object sender, EventArgs e)
        {
            AutoChangeColor.changeSPanelScreen2(this, searchSPanel);
            AutoChangeColor.changeSPanelScreen2(this, reLoadSPanel);
        }
        #endregion
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
        private void themMoiBtn_Click(object sender, EventArgs e)
        {
            var startScreenForm = this.Parent as SecondScreen;
            ThemMoiScreen themMoiScreen = new ThemMoiScreen();
            themMoiScreen.getFormRef(startScreenForm);
            OpenScreen.openAnotherScreen(startScreenForm, themMoiScreen, 1);
        }
        
        private void xemChiTietBtn_Click(object sender, EventArgs e)
        {
            var startScreenForm = this.Parent as SecondScreen;
            XemChiTiet xemChiTietScreen = new XemChiTiet();
            xemChiTietScreen.getFormRef(startScreenForm);
            OpenScreen.openAnotherScreen(startScreenForm, xemChiTietScreen, 1);
        }

        private void NhanKhauUC_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null; 
        }

        private void chinhSuaBtn_Click(object sender, EventArgs e)
        {
            var startScreenForm = this.Parent as SecondScreen;
            ChinhSua chinhSua = new ChinhSua();
            chinhSua.getFormRef(startScreenForm);
            OpenScreen.openAnotherScreen(startScreenForm, chinhSua, 1);
        }

        private void dKTamVangBtn_Click(object sender, EventArgs e)
        {
            var startScreenForm = this.Parent as SecondScreen;
            DKTamVang dKTamVang = new DKTamVang();
            dKTamVang.getFormRef(startScreenForm);
            OpenScreen.openAnotherScreen(startScreenForm, dKTamVang, 1);
        }

        private void dKTamTruBtn_Click(object sender, EventArgs e)
        {
            var startScreenForm = this.Parent as SecondScreen;
            DKTamTru dKTamTru = new DKTamTru();
            dKTamTru.getFormRef(startScreenForm);
            OpenScreen.openAnotherScreen(startScreenForm, dKTamTru, 1);
        }

        private void khaiTuBtn_Click(object sender, EventArgs e)
        {
            var startScreenForm = this.Parent as SecondScreen;
            KhaiTu dKKhaiTu = new KhaiTu();
            dKKhaiTu.getFormRef(startScreenForm);
            OpenScreen.openAnotherScreen(startScreenForm, dKKhaiTu, 1);
        }
        
    }
}
