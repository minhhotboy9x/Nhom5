# Hướng dẫn sử dụng

## Dành cho người dùng
Clone link repo https://github.com/minhhotboy9x/Nhom5.git.

Giải nén file [testNhom5.rar](testNhom5.rar) và chạy file setup.exe để cài đặt.

Sau khi cài đặt hoàn tất, click vào chương trình "Quan ly to dan pho" trên desktop để sử dụng.

## Dành cho nhà phát triển
Tải Visual Studio.

Clone link repo https://github.com/minhhotboy9x/Nhom5.git.

Mở solution [Nhom5.sln](Nhom5.sln).

Mở file [SQLQuery3.sql](SQLQuery3.sql) bằng Microsoft SQL Server Management Studio 18 và chạy các lệnh query trong file.
Chuột phải vào database nmcnpm_teamAKAM > Propertise > Chọn Files trong mục select a page > copy path của file nmcnpm_teamAKAM.
Vào đường link đã copy và copy 2 file nmcnpm_teamAKAM.mdf và nmcnpm_teamAKAM_log.ldf. Dán 2 file đã copy vào project Nhom5.csproj trong Visual Studio.

Mở  Package Manager Console trong Visual Studio và chạy lệnh:
```
Install-Package System.Linq.Dynamic.Core
```

Ấn Start trong Visual Studio để chạy chương trình.



