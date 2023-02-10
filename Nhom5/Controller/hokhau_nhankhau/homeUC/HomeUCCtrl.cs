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
            return dbContext.db.nhan_khau.Count();
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
