namespace LTQL_quanlythuvien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Tacgia : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tacgias",
                c => new
                    {
                        Matacgia = c.String(nullable: false, maxLength: 128),
                        Tentacgia = c.String(),
                        Ghichu = c.String(),
                    })
                .PrimaryKey(t => t.Matacgia);
            
            AlterColumn("dbo.Sachs", "Matacgia", c => c.String(maxLength: 128));
            CreateIndex("dbo.Sachs", "Matacgia");
            AddForeignKey("dbo.Sachs", "Matacgia", "dbo.Tacgias", "Matacgia");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sachs", "Matacgia", "dbo.Tacgias");
            DropIndex("dbo.Sachs", new[] { "Matacgia" });
            AlterColumn("dbo.Sachs", "Matacgia", c => c.String());
            DropTable("dbo.Tacgias");
        }
    }
}
