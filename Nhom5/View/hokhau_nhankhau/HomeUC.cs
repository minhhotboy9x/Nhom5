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
        private void changeLabelColor(SPanel sPanel, Color color)
        {
            foreach (Control label in sPanel.Controls)
            {
                //Console.WriteLine(label.GetType());
                if (label.GetType() == typeof(Label))
                {
                    
                    label.BackColor = color;
                }
            }
        }
        private void HomeUC_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                try
                {
                    var secondScreenForm = this.Parent as SecondScreen;
                    Button currentBtn = secondScreenForm.CurrentButton;
                    Color currentColor = currentBtn.BackColor;
                    foreach (Control panel in this.Controls)
                    {
                        if (panel.GetType() == typeof(SPanel))
                        {
                            SPanel sPanel = panel as SPanel;
                            sPanel.setFillColor(currentColor);
                            changeLabelColor(sPanel, currentColor);
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }       
        }
    }
}
