using System;
using System.Windows.Forms;

namespace Controller
{
public partial class TrangChuController : Form
{
private Label tongNhanKhauThuongTru;
private Label tongNhanKhauTamTru;
private Label tongNhanKhauTamVang;
private Label tongHoKhauThuongTru;
    NhanKhauRepository nhanKhauRepository = new NhanKhauRepositoryImpl();
    HoKhauRepository hoKhauRepository = new HoKhauRepositoryImpl();

    public TrangChuController()
    {
        InitializeComponent();
    }

    private void TrangChuController_Load(object sender, EventArgs e)
    {
        tongNhanKhauThuongTru.Text = Convert.ToString(nhanKhauRepository.tongNhanKhauThuongTru());
        tongNhanKhauTamTru.Text = Convert.ToString(nhanKhauRepository.tongNhanKhauTamTru());
        tongNhanKhauTamVang.Text = Convert.ToString(nhanKhauRepository.tongNhanKhauTamVang());
        tongHoKhauThuongTru.Text = Convert.ToString(hoKhauRepository.tongHoKhauThuongTru());
    }
}
