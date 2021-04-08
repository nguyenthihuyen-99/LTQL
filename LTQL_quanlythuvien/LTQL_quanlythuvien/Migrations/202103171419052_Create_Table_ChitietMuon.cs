namespace LTQL_quanlythuvien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_ChitietMuon : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChitietMuons",
                c => new
                    {
                        MaCTmuon = c.String(nullable: false, maxLength: 128),
                        Mamuon = c.String(maxLength: 128),
                        Ngaytra = c.DateTime(nullable: false),
                        Songayquahan = c.Int(nullable: false),
                        Tienphat = c.Int(nullable: false),
                        Ghichu = c.String(),
                    })
                .PrimaryKey(t => t.MaCTmuon)
                .ForeignKey("dbo.Muons", t => t.Mamuon)
                .Index(t => t.Mamuon);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChitietMuons", "Mamuon", "dbo.Muons");
            DropIndex("dbo.ChitietMuons", new[] { "Mamuon" });
            DropTable("dbo.ChitietMuons");
        }
    }
}
