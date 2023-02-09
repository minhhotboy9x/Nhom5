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

namespace Nhom5.View.hokhau_nhankhau
{
    public partial class HomeUC : UserControl
    {
        public HomeUC()
        {
            InitializeComponent();
           
        }
        public void HomeUC_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                foreach (Control panel in this.Controls)
                {
                    if (panel.GetType() == typeof(SPanel))
                    {
                        AutoChangeColor.changeSPanelScreen2(sender, panel as SPanel);
                    }
                }
            }    
        }
    }
}
