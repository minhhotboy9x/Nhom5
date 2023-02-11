using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom5.Controller.hokhau_nhankhau.homeUC
{
    public static class HomeUCCtrl
    {
        public static int layNhanKhau()
        {
            return dbContext.db.nhan_khau.AsQueryable()
                .Where(p => p.trangThai.ToLower() == "Thường trú".ToLower()
                || p.trangThai.ToLower() == "Tạm trú".ToLower()).Count();
        }
        public static int layHoKhau()
        {
            return dbContext.db.ho_khau.Count();
        }

        public static int layTamTru()
        {
            return dbContext.db.tam_tru.Count();
        }

        public static int layTamVang()
        {
            return dbContext.db.tam_vang.Count();
        }

    }
}
