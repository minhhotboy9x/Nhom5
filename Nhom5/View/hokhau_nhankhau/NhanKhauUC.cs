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
            
        }

        private void NhanKhauUC_VisibleChanged(object sender, EventArgs e)
        {
            AutoChangeColor.changeColorScreen2(sender, e, new List<String>() {"Button"});
        }

        private void themMoiBtn_Click(object sender, EventArgs e)
        {
            var startScreenForm = this.Parent as SecondScreen;
            ThemMoiScreen themMoiScreen = new ThemMoiScreen();
            themMoiScreen.getFormRef(startScreenForm);
            OpenScreen.openAnotherScreen(startScreenForm, themMoiScreen, 1);
        }
    }
}
