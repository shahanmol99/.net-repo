namespace EFConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V3_removeType_Customer : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Type", c => c.String());
        }
    }
}
