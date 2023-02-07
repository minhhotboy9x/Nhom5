using Nhom5.Utility;
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
    public partial class QuanLyPhanThuong : UserControl
    {
        public QuanLyPhanThuong()
        {
            InitializeComponent();
        }

        private void QuanLyPhanThuong_VisibleChanged(object sender, EventArgs e)
        {
            AutoChangeColor.changeColorScreen2(sender, e, new List<String>() { "Button" });
        }

        private void hsgBtn_Click(object sender, EventArgs e)
        {
            var secondScreen = this.Parent as SecondScreen;
            secondScreen.open_HocSinhGioiUC();
        }
    }
}
