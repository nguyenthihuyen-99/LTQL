namespace LTQL_quanlythuvien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Database : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Muons", "Madocgia", c => c.String(maxLength: 128));
            AlterColumn("dbo.Sachs", "MaNXB", c => c.String(maxLength: 128));
            CreateIndex("dbo.Muons", "Madocgia");
            CreateIndex("dbo.Sachs", "MaNXB");
            AddForeignKey("dbo.Muons", "Madocgia", "dbo.Docgias", "Madocgia");
            AddForeignKey("dbo.Sachs", "MaNXB", "dbo.NhaXuatBans", "MaNXB");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sachs", "MaNXB", "dbo.NhaXuatBans");
            DropForeignKey("dbo.Muons", "Madocgia", "dbo.Docgias");
            DropIndex("dbo.Sachs", new[] { "MaNXB" });
            DropIndex("dbo.Muons", new[] { "Madocgia" });
            AlterColumn("dbo.Sachs", "MaNXB", c => c.String());
            AlterColumn("dbo.Muons", "Madocgia", c => c.String());
        }
    }
}
