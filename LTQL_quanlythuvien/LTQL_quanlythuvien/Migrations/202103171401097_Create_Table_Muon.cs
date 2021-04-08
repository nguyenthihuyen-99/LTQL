namespace LTQL_quanlythuvien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Muon : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Muons",
                c => new
                    {
                        Mamuon = c.String(nullable: false, maxLength: 128),
                        Madocgia = c.String(),
                        Masach = c.String(),
                        MaNV = c.String(),
                        Ngaymuon = c.String(),
                        Hanphaitra = c.String(),
                        Ghichu = c.String(),
                    })
                .PrimaryKey(t => t.Mamuon);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Muons");
        }
    }
}
