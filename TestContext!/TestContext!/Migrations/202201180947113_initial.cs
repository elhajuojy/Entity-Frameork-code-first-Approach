namespace TestContext_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.students",
                c => new
                    {
                        Idet = c.Int(nullable: false, identity: true),
                        NomEtudaint = c.String(name: "Nom Etudaint"),
                        age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Idet);
            
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
            DropTable("dbo.students");
        }
    }
}
