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
        #region change sPanel color
        public void HoKhauUC_VisibleChanged(object sender, EventArgs e)
        {
            AutoChangeColor.changeColorScreen2(sender, e, new List<String>() { "Button" });
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
        private void HoKhauUC_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void themMoiBtn_Click(object sender, EventArgs e)
        {
            OpenScreen.openFunctionForm(this, new ThemMoiHoKhau(), 1);
        }

        private void xemChiTietBtn_Click(object sender, EventArgs e)
        {
            OpenScreen.openFunctionForm(this, new XemHoKhau(), 1);
        }

        private void chinhSuaBtn_Click(object sender, EventArgs e)
        {
            OpenScreen.openFunctionForm(this, new ChinhSuaHoKhau(), 1);
        }

        private void tachHoKhauBtn_Click(object sender, EventArgs e)
        {
            OpenScreen.openFunctionForm(this, new TachHoKhau(), 1);
        }
        
        private void chuyenKhauBtn_Click(object sender, EventArgs e)
        {
            OpenScreen.openFunctionForm(this, new ChuyenHoKhau(), 1);
        }

        private void lichSuBtn_Click(object sender, EventArgs e)
        {
            OpenScreen.openFunctionForm(this, new LichSuChuyenDi(), 1);
        }

        private void reLoadSPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchSPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
