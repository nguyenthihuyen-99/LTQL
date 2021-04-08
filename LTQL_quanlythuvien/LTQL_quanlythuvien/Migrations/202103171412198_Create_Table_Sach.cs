namespace LTQL_quanlythuvien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Sach : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sachs",
                c => new
                    {
                        Masach = c.String(nullable: false, maxLength: 30),
                        Tensach = c.String(),
                        Tentacgia = c.String(),
                        Matacgia = c.String(),
                        Matheloai = c.String(),
                        NamXB = c.Int(nullable: false),
                        MaNXB = c.String(),
                    })
                .PrimaryKey(t => t.Masach);
            
            AlterColumn("dbo.Muons", "Masach", c => c.String(maxLength: 30));
            CreateIndex("dbo.Muons", "Masach");
            AddForeignKey("dbo.Muons", "Masach", "dbo.Sachs", "Masach");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Muons", "Masach", "dbo.Sachs");
            DropIndex("dbo.Muons", new[] { "Masach" });
            AlterColumn("dbo.Muons", "Masach", c => c.String());
            DropTable("dbo.Sachs");
        }
    }
}
