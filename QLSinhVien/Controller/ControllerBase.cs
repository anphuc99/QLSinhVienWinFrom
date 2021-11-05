using QLSinhVien.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien.Controller
{
    public class ControllerBase
    {
        public QLSinhVienEntities db { get; set; }
        public static User user { get; set; }
        public ControllerBase()
        {
            LoginController login = new LoginController();
            if (!login.Login(user?.TaiKhoan, user?.MatKhau))
            {
                throw new InvalidOperationException("Vui lòng đăng nhập!");
            }
            db = new QLSinhVienEntities();
        }
    }
}
