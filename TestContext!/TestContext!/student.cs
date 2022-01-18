using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestContext_
{
    public class student
    {
        [Key]
        public int Idet { get; set; }

        [Column("Nom Etudaint")]
        public string Name { get; set; }

        [Required]
        public int age { get; set; }

    }
}
