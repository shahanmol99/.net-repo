namespace EFConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V2_TypeAdd_Customers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Type", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Type");
        }
    }
}
