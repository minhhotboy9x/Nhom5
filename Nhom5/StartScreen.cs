using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Nhom5
{
    public partial class StartScreen : Form
    {
        Thread th;
        public StartScreen()
        {
            InitializeComponent();

        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            changeToLogin();
        }

        public void changeToLogin()
        {
            loginUC1.Show();
            signUpUC1.Hide();
            forgetPassUC1.Hide();
            resetPassUC1.Hide();
        }
        public void changeToSignUp()
        {
            loginUC1.Hide();
            signUpUC1.Show();
            forgetPassUC1.Hide();
            resetPassUC1.Hide();
        }

        public void changeToForget()
        {
            signUpUC1.Hide();
            loginUC1.Hide();
            forgetPassUC1.Show();
            resetPassUC1.Hide();
        }

        public void changeToReset()
        {
            signUpUC1.Hide();
            loginUC1.Hide();
            forgetPassUC1.Hide();
            resetPassUC1.Show();
        }
        public void runSecondScreen()
        {
            Application.Run(new SecondScreen());
        }
        public void openSecondScreen()
        {
            this.Close();
            th = new Thread(runSecondScreen);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
