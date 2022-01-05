using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Entity_Framework_code_First_Approach_project_Practice.Models
{
    public class CEContext:DbContext
    {

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
