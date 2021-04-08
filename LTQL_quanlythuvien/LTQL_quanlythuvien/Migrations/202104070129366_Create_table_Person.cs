namespace LTQL_quanlythuvien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_Person : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.persons",
                c => new
                    {
                        CCCD = c.String(nullable: false, maxLength: 128),
                        hoten = c.String(),
                    })
                .PrimaryKey(t => t.CCCD);
            
            CreateTable(
                "dbo.nghenghieps",
                c => new
                    {
                        CCCD = c.String(nullable: false, maxLength: 128),
                        congty = c.String(),
                    })
                .PrimaryKey(t => t.CCCD)
                .ForeignKey("dbo.persons", t => t.CCCD)
                .Index(t => t.CCCD);
            
            CreateTable(
                "dbo.students",
                c => new
                    {
                        CCCD = c.String(nullable: false, maxLength: 128),
                        tentruong = c.String(),
                    })
                .PrimaryKey(t => t.CCCD)
                .ForeignKey("dbo.persons", t => t.CCCD)
                .Index(t => t.CCCD);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.students", "CCCD", "dbo.persons");
            DropForeignKey("dbo.nghenghieps", "CCCD", "dbo.persons");
            DropIndex("dbo.students", new[] { "CCCD" });
            DropIndex("dbo.nghenghieps", new[] { "CCCD" });
            DropTable("dbo.students");
            DropTable("dbo.nghenghieps");
            DropTable("dbo.persons");
        }
    }
}
