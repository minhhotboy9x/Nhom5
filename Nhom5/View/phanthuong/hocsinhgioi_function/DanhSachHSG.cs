using Nhom5.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom5.View.hokhau_nhankhau.nhankhau_function
{
    public partial class DanhSachHSG : FunctionForm
    {
        public DanhSachHSG()
        {
            InitializeComponent();
        }

        private void dongBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void themMinhChungBtn_Click(object sender, EventArgs e)
        {
            
            MinhChungHSG minhChung = new MinhChungHSG();
            minhChung.getForm_ColorRef(this, this.themMinhChungBtn.BackColor);
            void runSecondScreen()
            {
                Application.Run(minhChung);
            }
            Thread th = new Thread(runSecondScreen);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Enabled = false;
        }
    }
}
