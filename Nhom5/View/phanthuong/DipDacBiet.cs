using Nhom5.Utility;
using Nhom5.View.hokhau_nhankhau.nhankhau_function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom5.View.phanthuong
{
    public partial class DipDacBiet : UserControl
    {
        public DipDacBiet()
        {
            InitializeComponent();
        }
        public void DipDacBiet_VisibleChanged(object sender, EventArgs e)
        {
            AutoChangeColor.changeColorScreen2(sender, e, new List<String>() { "Button" });
            AutoChangeColor.changeSPanelScreen2(sender, searchSPanel);
            AutoChangeColor.changeSPanelScreen2(sender, reLoadSPanel);
        }
        private void taoDipBtn_Click(object sender, EventArgs e)
        {
            OpenScreen.openFunctionForm(this, new TaoDipDacBiet(), 1);
        }

        private void xemChiTietBtn_Click(object sender, EventArgs e)
        {
            OpenScreen.openFunctionForm(this, new ChiTietDip(), 1);
        }

        private void chinhSuaBtn_Click(object sender, EventArgs e)
        {
            OpenScreen.openFunctionForm(this, new ChinhSuaDip(), 1);
        }

        private void xemDanhSachBtn_Click(object sender, EventArgs e)
        {
            OpenScreen.openFunctionForm(this, new DanhSachDip(), 1);
        }
    }
}
