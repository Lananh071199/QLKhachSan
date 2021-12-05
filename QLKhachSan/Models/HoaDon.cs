using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLKhachSan.Models
{
    [Table("HoaDon")]
    public class HoaDon
    {
        [Key]
        public String MaHD { get; set; }
        public String MaKH { get; set; }
        public float SoTien { get; set; }
        public string NgayTT { get; set; }
        public String HinhThucTT { get; set; }
    }
}