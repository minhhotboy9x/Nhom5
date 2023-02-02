using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom5.Utility
{
    public static class AutoChangeColor
    {
        public static void changeColorScreen2(object sender, EventArgs e, List<String> list_type)
        {
            UserControl This_UC = sender as UserControl;
            if (This_UC.Visible)
            {
                try
                {
                    var secondScreenForm = This_UC.Parent as SecondScreen;
                    Button currentBtn = secondScreenForm.CurrentButton;
                    Color currentColor = currentBtn.BackColor;
                    foreach (Control btn in This_UC.Controls)
                    {
                        //Console.WriteLine(list_type.Contains("Button"));
                        if (list_type.Contains(btn.GetType().Name.ToString()))
                        {
                            btn.BackColor = currentColor;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
