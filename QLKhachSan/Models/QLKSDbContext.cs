using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLKhachSan.Models
{
    public partial class QLKSDbContext : DbContext
    {
        public QLKSDbContext()
            : base("name=QLKSDbContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<QLKhachSan.Models.Accounts> Accounts { get; set; }

        public System.Data.Entity.DbSet<QLKhachSan.Models.DichVu> DichVus { get; set; }

        public System.Data.Entity.DbSet<QLKhachSan.Models.HoaDon> HoaDons { get; set; }

        public System.Data.Entity.DbSet<QLKhachSans.Models.KhachHang> KhachHangs { get; set; }

        public System.Data.Entity.DbSet<QLKS.Models.Phong> Phongs { get; set; }

        public System.Data.Entity.DbSet<QLKhachSan.Models.ThuePhong> ThuePhongs { get; set; }
    }
}
