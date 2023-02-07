using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom5.View.hokhau_nhankhau.hokhau_function
{
    public partial class XemHoKhau : FunctionForm
    {
        public XemHoKhau()
        {
            InitializeComponent();
        }

        private void dongBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
