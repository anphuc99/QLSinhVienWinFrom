using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien.Model
{
    [Serializable()]
    public class User
    {
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public static string ObjectToString(object obj)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                new BinaryFormatter().Serialize(ms, obj);
                return Convert.ToBase64String(ms.ToArray());
            }
        }
        private static object StringToObject(string base64String)
        {
            byte[] bytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length))
            {
                ms.Write(bytes, 0, bytes.Length);
                ms.Position = 0;
                return new BinaryFormatter().Deserialize(ms);
            }
        }

        public static User getUser()
        {
            QLSinhVienEntities db = new QLSinhVienEntities();
            TaiKhoan taiKhoan = db.TaiKhoans.First();
            return new User() {TaiKhoan = taiKhoan.TaiKhoan1, MatKhau = taiKhoan.MatKhau };
        }
    }
}
