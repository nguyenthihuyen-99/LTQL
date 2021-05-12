namespace LTQL_quanlythuvien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_alter_sdt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Nhanviens", "Sodienthoai", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Nhanviens", "Sodienthoai", c => c.Int(nullable: false));
        }
    }
}
