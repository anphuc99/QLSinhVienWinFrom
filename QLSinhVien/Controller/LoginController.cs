using QLSinhVien.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien.Controller
{
    public class LoginController
    {
        public bool Login(string tk, string mk)
        {
            User user = User.getUser();
            if (tk == user.TaiKhoan && mk == user.MatKhau)
            {
                ControllerBase.user = user;
                return true;
            }
            return false;
        }
    }
}
