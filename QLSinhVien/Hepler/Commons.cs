using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien.Hepler
{
    public static class Commons
    {
        public static string ObjectToString(object obj)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                new BinaryFormatter().Serialize(ms, obj);
                return Convert.ToBase64String(ms.ToArray());
            }
        }

        public static object StringToObject(string base64String)
        {
            byte[] bytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length))
            {
                ms.Write(bytes, 0, bytes.Length);
                ms.Position = 0;
                return new BinaryFormatter().Deserialize(ms);
            }
        }



        public static string readFile(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line, str = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        str += line;
                    }
                    sr.Close();
                    return str;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static bool writeFile(string path, string text)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.Write(text);
                    writer.Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static string sinhDuLieuHoTen()
        {
            string[] Ten = { "Vương", "Tường", "Tuấn", "Trưởng", "Trung", "Triển", "Trân", "Tiến", "Thương", "Thịnh", "Thảo", "Thành", "Thanh", "Tân", "Sơn", "Quỳnh", "Quí", "Quang", "Phương", "Phúc", "Phúc", "Phúc", "Phát", "Phát", "Nhựt", "Như", "Nhân", "Nhân", "Nghĩa", "Ngân", "Nam", "Nam", "Minh", "Minh", "Lụa", "Lợi", "Lộc", "Kiệt", "Khoa", "Khiêm", "Khang", "Huy", "Huy", "Hương", "Huệ", "Hoàng", "Hoàng", "Hòa", "Hiếu", "Hiếu", "Duy", "Duy", "Duy", "Dương", "Dũng", "Đạt", "Đạt", "Bình", "Bảo", "Bảng", "An" };
            string[] TenLot = { "", "Công", "Duy", "Anh", "Quốc", "Thành", "Phát", "Ngọc", "Linh", "Vĩnh", "Văn", "Thu", "Kim", "Hoàng", "Nhật", "Ngọc", "Văn", "Quang", "Huy", "Thanh", "Minh", "Hoàng", "An", "Tấn", "Tấn", "Minh", "Ý", "Việt", "Thiện", "Hiếu", "Kim", "Duy", "Văn", "Quang", "Văn", "Thị", "Ngọc", "Thanh", "Quốc", "Đình", "Văn", "Duy", "Hữu", "Gia", "Xuân", "Bích", "Minh", "Huy", "Ngọc", "Minh", "Minh", "Trung", "Khánh", "Khánh", "Viết", "Phúc", "Văn", "Phụng", "Thanh", "Gia", "Kim", "Trường" };
            string[] Ho = { "Trương", "Trần", "Nguyễn", "Phan", "Nguyễn", "Trịnh", "Lê", "Lê", "Lê", "Đinh", "Đoàn", "Vương", "Phan", "Nguyễn", "Vũ", "Tô", "Phan", "Lý", "Văn", "Trịnh", "Nguyễn", "Lồng", "Nguyễn", "Nguyễn", "Lê", "Huỳnh", "Huỳnh", "Châu", "Đoàn", "Nguyễn", "Đào", "Cao", "Lê", "Bùi", "Nguyễn", "Mã", "Lâm", "Huỳnh", "Lê", "Lê", "Lê", "Vũ", "Nguyễn", "Lâm", "Nguyễn", "Trần", "Lê", "Nguyễn", "Nguyễn", "Dương", "Quách", "Nguyễn", "Nguyễn", "Hoàng", "Trương", "Lại", "Huỳnh", "Tô", "Nguyễn", "Bùi", "Mai", };
            Random rd = new Random();
            return Ho[rd.Next(0, Ho.Length - 1)] + " " + TenLot[rd.Next(0, TenLot.Length - 1)] + " " + Ten[rd.Next(0, Ten.Length - 1)];
        }

        public static bool FindAndReplaceText(string findText, string replaceText, Find find)
        {
            if (string.IsNullOrEmpty(replaceText))
                replaceText = string.Empty;
            find.Text = string.Empty;
            find.ClearFormatting();
            return find.Execute(findText, null, null, null, null, null, null, null, null, replaceText);
        }
        public static DataSet ToDataSet<T>(this IList<T> list)
        {
            Type elementType = typeof(T);
            DataSet ds = new DataSet();
            System.Data.DataTable t = new System.Data.DataTable();
            ds.Tables.Add(t);

            //add a column to table for each public property on T
            foreach (var propInfo in elementType.GetProperties())
            {
                Type ColType = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;

                t.Columns.Add(propInfo.Name, ColType);
            }

            //go through each property on T and add each value to the table
            foreach (T item in list)
            {
                DataRow row = t.NewRow();

                foreach (var propInfo in elementType.GetProperties())
                {
                    row[propInfo.Name] = propInfo.GetValue(item, null) ?? DBNull.Value;
                }

                t.Rows.Add(row);
            }

            return ds;
        }
    }
}
