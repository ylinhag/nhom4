using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nhom4.Models
{
    public class TheLoai
    {

        [Key]
        public int MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }



    }
}
