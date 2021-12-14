namespace QLKhachSan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_All : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Username);
            
            CreateTable(
                "dbo.DichVu",
                c => new
                    {
                        MaDV = c.String(nullable: false, maxLength: 128),
                        TenDV = c.String(),
                        DonGiaVN = c.String(),
                    })
                .PrimaryKey(t => t.MaDV);
            
            CreateTable(
                "dbo.HoaDon",
                c => new
                    {
                        MaHD = c.String(nullable: false, maxLength: 128),
                        MaKH = c.String(),
                        SoTien = c.Single(nullable: false),
                        NgayTT = c.String(),
                        HinhThucTT = c.String(),
                    })
                .PrimaryKey(t => t.MaHD);
            
            CreateTable(
                "dbo.KhachHang",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 128),
                        HoTenKH = c.String(),
                        SoDT = c.String(),
                    })
                .PrimaryKey(t => t.MaKH);
            
            CreateTable(
                "dbo.Phong",
                c => new
                    {
                        MaPhong = c.String(nullable: false, maxLength: 128),
                        TenPhong = c.String(),
                        LoaiPhong = c.String(),
                        TrangThai = c.String(),
                        GiaPhong = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhong);
            
            CreateTable(
                "dbo.ThuePhong",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 128),
                        NgayDen = c.String(),
                        NgayDi = c.String(),
                        ThanhToan = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.MaKH);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ThuePhong");
            DropTable("dbo.Phong");
            DropTable("dbo.KhachHang");
            DropTable("dbo.HoaDon");
            DropTable("dbo.DichVu");
            DropTable("dbo.Accounts");
        }
    }
}
