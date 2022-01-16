using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamsApp
{
    public class Student
    {
       [Key]
       public int Id { get; set; }
        public string NameStudent { get; set; }

        public int StudentAge { get; set; }

        public int idteacher { get; set; }


        

    }
}
