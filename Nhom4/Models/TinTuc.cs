using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nhom4.Models
{
    public class TinTuc
    {
        [Key]
        public int MaTin { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public string Anh { get; set; }
        public DateTime NgayDang { get; set; }
        public string NguoiDang { get; set; }
        public int MaTheLoai { get; set; }



    }
}
