namespace LTQL_quanlythuvien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhaXuatBan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhaXuatBans",
                c => new
                    {
                        MaNXB = c.String(nullable: false, maxLength: 128),
                        TenNXB = c.String(),
                        Ghichu = c.String(),
                    })
                .PrimaryKey(t => t.MaNXB);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhaXuatBans");
        }
    }
}
