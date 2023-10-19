using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WindowsFormsApp.Model
{
    public class SinhVien
    {
        public string MaSinhVien {  get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public GIOITINH GioiTinh { get; set; }
        public string NoiSinh { get; set; }
        public string HinhDaiDien { get; set; }

        public override string ToString()
        {
           var json = JsonSerializer.Serialize(this);
            return json;
        }
        public static SinhVien FromJson(string json)
        {
            var obj = JsonSerializer.Deserialize<SinhVien>(json);
            return obj;
        }
    }
    public enum GIOITINH
    {
        Nam, Nu, Khac
    }
}
