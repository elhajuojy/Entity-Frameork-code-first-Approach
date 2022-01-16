namespace Ef_code_First_UI_practice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "HireDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Employees", "salary", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Employees", "job", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "job");
            DropColumn("dbo.Employees", "salary");
            DropColumn("dbo.Employees", "HireDate");
        }
    }
}
