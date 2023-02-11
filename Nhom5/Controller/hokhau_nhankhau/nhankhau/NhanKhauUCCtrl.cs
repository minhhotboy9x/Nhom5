using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic;
using System.Linq.Expressions;

namespace Nhom5.Controller.hokhau_nhankhau.nhankhau
{
    public static class NhanKhauUCCtrl
    {
        public static async void loadNhanKhau(DataGridView dtview)
        {
            dtview.DataSource = await Task.Run(() =>
            {
               return dbContext.db.nhan_khau
               .Select(p => new { p.idNhanKhau, p.hoTen, p.ngaySinh, p.gioiTinh, p.cmnd, p.trangThai })
               .ToList();
            });
            dtview.Columns[0].HeaderText = "ID nhân khẩu";
            dtview.Columns[1].HeaderText = "Họ tên";
            dtview.Columns[2].HeaderText = "Ngày sinh";
            dtview.Columns[3].HeaderText = "Giới tính";
            dtview.Columns[4].HeaderText = "CCCD/CMND";
            dtview.Columns[5].HeaderText = "Trạng thái";
            //Console.WriteLine(dtview.Columns[5].Name);
            foreach (DataGridViewColumn column in dtview.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        public static async void traCuuNhanKhau(DataGridView dtview, String headText, String value)
        {
            int Index = 0;
            for(int i=0;i<=5;i++)
            if(dtview.Columns[i].HeaderText == headText)
            {
                    Index = i;
                    break;
            }
            string columnName = dtview.Columns[Index].Name;
            var columnType = dbContext.db.nhan_khau.First().GetType().GetProperty(columnName).PropertyType;
            if (columnType.IsAssignableFrom(typeof(int)))
            {
                int res = 0;
                if (int.TryParse(value, out res))
                {
                    // Sử lý nếu column là kiểu int
                    dtview.DataSource = await Task.Run(() =>
                    {
                        return dbContext.db.nhan_khau
                            .AsQueryable()
                            .Where(string.Format("{0}=@0", columnName), res)
                            .Select(p => new { p.idNhanKhau, p.hoTen, p.ngaySinh, p.gioiTinh, p.cmnd, p.trangThai })
                            .ToList();
                    });
                }
            }
            else
            {
                // Sử lý nếu column không phải là kiểu int
                dtview.DataSource = await Task.Run(() =>
                {
                    return dbContext.db.nhan_khau
                        .AsQueryable()
                        .Where(string.Format("{0}.Contains(@0)", columnName.ToString()), value.ToString())
                        .Select(p => new { p.idNhanKhau, p.hoTen, p.ngaySinh, p.gioiTinh, p.cmnd, p.trangThai })
                        .ToList();
                });
            }
        }

        public static bool themNhanKhau(
            String hoten,
            String bidanh,
            DateTime ngaysinh,
            String noisinh,
            String gioitinh,
            String nguyenquan,
            String dantoc,
            String tongiao,
            String quoctich,
            String nghenghiep,
            String noilamviec,
            String cmnd,
            DateTime ngaycap,
            DateTime chuyendenngay,
            String noithuongtrutruoc,
            String trangthai
            )
        {
            dbContext.db.nhan_khau.Add(
                new nhan_khau()
                {
                    hoTen = hoten,
                    biDanh = bidanh,
                    ngaySinh = ngaysinh,
                    noiSinh = noisinh,
                    gioiTinh = gioitinh,
                    nguyenQuan = nguyenquan,
                    danToc = dantoc,
                    tonGiao = tongiao,
                    quocTich = quoctich,
                    ngheNghiep = nghenghiep,
                    noiLamViec = noilamviec,
                    cmnd = cmnd,
                    ngayCap = ngaycap,
                    chuyenDenNgay = chuyendenngay,
                    noiThuongTruTruoc = noithuongtrutruoc,
                    trangThai = trangthai
                });
            if(hoten=="" || quoctich==""  || noisinh==""  || nguyenquan == ""
               || dantoc=="" || tongiao == "" )
            {
                return false;
            }    
            try
            {
                dbContext.db.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                //xoá mọi query
                foreach (var entry in dbContext.db.ChangeTracker.Entries())
                {
                    entry.State = (System.Data.Entity.EntityState)EntityState.Detached;

                }
                dbContext.db.SaveChanges();
                return false;
            }
            return true;
        }
        
        public static nhan_khau xemNhanKhau(int id)
        {
            return null;
        }
    }
}
