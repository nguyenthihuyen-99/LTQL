namespace LTQL_quanlythuvien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Nhanvien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nhanviens",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 128),
                        HotenNV = c.String(),
                        Email = c.String(),
                        Sodienthoai = c.Int(nullable: false),
                        Ghichu = c.String(),
                    })
                .PrimaryKey(t => t.MaNV);
            
            AlterColumn("dbo.Muons", "MaNV", c => c.String(maxLength: 128));
            CreateIndex("dbo.Muons", "MaNV");
            AddForeignKey("dbo.Muons", "MaNV", "dbo.Nhanviens", "MaNV");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Muons", "MaNV", "dbo.Nhanviens");
            DropIndex("dbo.Muons", new[] { "MaNV" });
            AlterColumn("dbo.Muons", "MaNV", c => c.String());
            DropTable("dbo.Nhanviens");
        }
    }
}
