using System;
using System.Windows.Forms;

namespace Controller
{
public class NguoiDungController
{
private Button huyButton;
private Button dangNhapButton;
private TextBox taiKhoan;
private TextBox matKhau;
private Label dangNhapThatBaiMessage;
static NguoiDungRepository nguoiDungRepository = new NguoiDungRepositoryImpl();
    public void HuyButton_Click(object sender, EventArgs e)
    {
        Form form = (Form)huyButton.Parent;
        form.Close();
    }

    public void DangNhapButton_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(taiKhoan.Text) && !string.IsNullOrWhiteSpace(matKhau.Text))
        {
            if (nguoiDungRepository.dangNhap(taiKhoan.Text, matKhau.Text))
            {
                Form form = (Form)dangNhapButton.Parent;
                form.Close();

                Form mainForm = new Form();
                mainForm.Text = "Quản lý khu phố";
                mainForm.ClientSize = new System.Drawing.Size(1400, 780);
                mainForm.StartPosition = FormStartPosition.Manual;
                mainForm.Location = new System.Drawing.Point(10, 10);
                mainForm.Show();
            }
            else
            {
                dangNhapThatBaiMessage.Text = Message.dangNhapThatBai;
            }
        }
        else
        {
            dangNhapThatBaiMessage.Text = Message.dangNhapTrong;
        }
    }
}
