namespace LTQL_quanlythuvien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Theloai : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Theloais",
                c => new
                    {
                        Matheloai = c.String(nullable: false, maxLength: 128),
                        Tentheloai = c.String(),
                        Ghichu = c.String(),
                    })
                .PrimaryKey(t => t.Matheloai);
            
            AlterColumn("dbo.Sachs", "Matheloai", c => c.String(maxLength: 128));
            CreateIndex("dbo.Sachs", "Matheloai");
            AddForeignKey("dbo.Sachs", "Matheloai", "dbo.Theloais", "Matheloai");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sachs", "Matheloai", "dbo.Theloais");
            DropIndex("dbo.Sachs", new[] { "Matheloai" });
            AlterColumn("dbo.Sachs", "Matheloai", c => c.String());
            DropTable("dbo.Theloais");
        }
    }
}
