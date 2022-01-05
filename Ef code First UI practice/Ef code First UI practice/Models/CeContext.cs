using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Ef_code_First_UI_practice.Models
{
    public partial class CeContext : DbContext
    {
        public CeContext()
            : base("name=CeContext")
        {
        }

        public DbSet<Employee> Employees { get; set;}
        public DbSet<Company> Companys { get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
