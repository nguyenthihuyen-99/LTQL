namespace LTQL_quanlythuvien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Docgia : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Docgias",
                c => new
                    {
                        Madocgia = c.String(nullable: false, maxLength: 128),
                        Tendocgia = c.String(),
                        Mamuon = c.String(),
                        Ngaysinh = c.String(),
                        Ghichu = c.String(),
                    })
                .PrimaryKey(t => t.Madocgia);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Docgias");
        }
    }
}
