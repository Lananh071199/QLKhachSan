using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLKhachSan.Models
{
    [Table("ThuePhong")]
    public class ThuePhong
    {
        [Key]
        public String MaKH { get; set; }
        public String NgayDen { get; set; }
        public String NgayDi { get; set; }
        public float ThanhToan { get; set; }
    }
}