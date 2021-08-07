namespace EFConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4_changeIdDatatype_Customer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "ID", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.Customers");
            AddPrimaryKey("dbo.Customers", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Customers");
            AddPrimaryKey("dbo.Customers", "Id");
            AlterColumn("dbo.Customers", "ID", c => c.Int(nullable: false, identity: true));
        }
    }
}
