using System;
using System.Data.Entity;
using System.Linq;

namespace TestContext_
{
    public class teacherContext11 : DbContext
    {
        // Your context has been configured to use a 'teacherContext11' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TestContext_.teacherContext11' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'teacherContext11' 
        // connection string in the application configuration file.
        public teacherContext11()
            : base("name=teacherContext11")
        {
        }

        public DbSet<student> students { get; set; }
        public DbSet<Teacher> teachers { get; set; }


        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}