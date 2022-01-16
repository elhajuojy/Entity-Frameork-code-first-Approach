namespace TeamsApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameStudent = c.String(),
                        StudentAge = c.Int(nullable: false),
                        idteacher = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        idteacher = c.Int(nullable: false, identity: true),
                        firstnameteacher = c.String(),
                        lastNameteacher = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idteacher);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
        }
    }
}
