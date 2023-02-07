using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Controller
{
public partial class ManHinhChinhController : Window
{
public ManHinhChinhController()
{
InitializeComponent();
        Pane trangChuPane = new Pane();
        trangChuPane.Name = "trangChuPane";
        MainPane.Children.Add(trangChuPane);
    }

    private void ResetButtonBackground()
    {
        TrangChuButton.Style = (Style)FindResource("ButtonStyle");
        NhanKhauButton.Style = (Style)FindResource("ButtonStyle");
        HoKhauButton.Style = (Style)FindResource("ButtonStyle");
        PhanThuongButton.Style = (Style)FindResource("ButtonStyle");
        ThongKeButton.Style = (Style)FindResource("ButtonStyle");
    }

    private void TrangChuButton_Click(object sender, RoutedEventArgs e)
    {
        ResetButtonBackground();
        TrangChuButton.Style = (Style)FindResource("SelectedButtonStyle");

        Pane trangChuPane = new Pane();
        trangChuPane.Name = "trangChuPane";
        MainPane.Children.Add(trangChuPane);
    }

    private void NhanKhauButton_Click(object sender, RoutedEventArgs e)
    {
        ResetButtonBackground();
        NhanKhauButton.Style = (Style)FindResource("SelectedButtonStyle");

        Pane trangChuPane = new Pane();
        trangChuPane.Name = "nhanKhauPane";
        MainPane.Children.Add(trangChuPane);
    }

    private void HoKhauButton_Click(object sender, RoutedEventArgs e)
    {
        ResetButtonBackground();
        HoKhauButton.Style = (Style)FindResource("SelectedButtonStyle");

        Pane trangChuPane = new Pane();
        trangChuPane.Name = "hoKhauPane";
        MainPane.Children.Add(trangChuPane);
    }

    private void PhanThuongButton_Click(object sender, RoutedEventArgs e)
    {
        ResetButtonBackground();
        PhanThuongButton.Style = (Style)FindResource("SelectedButtonStyle");

        Pane trangChuPane = new Pane();
        trangChuPane.Name = "phanThuongPane";
        MainPane.Children.Add(trangChuPane);
    }

    private void ThongKeButton_Click(object sender, RoutedEventArgs e)
    {
        ResetButtonBackground();
        ThongKeButton.Style = (Style)FindResource("SelectedButtonStyle");

        Pane trangChuPane = new Pane();
        trangChuPane.Name = "thongKePane";
        MainPane.Children.Add(trangChuPane);
    }
    public void dangXuatButtonOnAction(ActionEvent event) throws IOException {
        Stage stage = (Stage) dangXuatButton.getScene().getWindow();
        Parent root = FXMLLoader.load(getClass().getResource("/view/dangNhap/dangNhap.fxml"));
        stage.setScene(new Scene(root));
        stage.show();
    }
}

