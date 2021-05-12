namespace LTQL_quanlythuvien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Tintuc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tintucs",
                c => new
                    {
                        TintucID = c.String(nullable: false, maxLength: 128),
                        Tentacgia = c.String(),
                        Noidung = c.String(),
                    })
                .PrimaryKey(t => t.TintucID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tintucs");
        }
    }
}
