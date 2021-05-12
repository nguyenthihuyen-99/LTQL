namespace LTQL_quanlythuvien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_UPDATE : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AccountModels", "RoleID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AccountModels", "RoleID");
        }
    }
}
