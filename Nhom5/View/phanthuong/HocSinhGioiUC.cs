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

namespace Nhom5.View.phanthuong
{
    public partial class HocSinhGioiUC : UserControl
    {
        public HocSinhGioiUC()
        {
            InitializeComponent();
        }

        public void HocSinhGioiUC_VisibleChanged(object sender, EventArgs e)
        {
            AutoChangeColor.changeColorScreen2(sender, e, new List<String>() { "Button" });
            AutoChangeColor.changeSPanelScreen2(sender, searchSPanel);
            AutoChangeColor.changeSPanelScreen2(sender, reLoadSPanel);
        }

        private void taoDipBtn_Click(object sender, EventArgs e)
        {
            OpenScreen.openFunctionForm(this, new TaoDipTraoThuong(), 1);
        }
    }
}
