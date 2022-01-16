using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EntityFrameworkWithAyoube
{
    public partial class _DbConttext : DbContext
    {
        public _DbConttext()
            : base("name=MehdiContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
