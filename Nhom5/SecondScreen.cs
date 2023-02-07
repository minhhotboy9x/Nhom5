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

namespace Nhom5
{
    public partial class SecondScreen : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;

        public Button CurrentButton { get => currentButton; set => currentButton = value; }

        public SecondScreen()
        {
            InitializeComponent();
            hideAllUC();
            random = new Random();
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);

                    //
                    lblTitle.Text = currentButton.Text;
                   
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            hideAllUC();
            ActivateButton(sender);
            homeUC1.Show();
        }

        private void nhanKhauBtn_Click(object sender, EventArgs e)
        {
            hideAllUC();
            ActivateButton(sender);
            nhanKhauUC1.Show();
        }

        private void hoKhauBtn_Click(object sender, EventArgs e)
        {
            hideAllUC();
            ActivateButton(sender);
            hoKhauUC1.Show();
        }

        private void thongKeBtn_Click(object sender, EventArgs e)
        {
            hideAllUC();
            ActivateButton(sender);
        }

        private void hideAllUC()
        {
            foreach (Control UC in this.Controls)
            {
                if (UC.GetType().BaseType == typeof(UserControl))
                {
                    UC.Hide();
                }
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            OpenScreen.openAnotherScreen(this, new StartScreen());
        }
    }
}
