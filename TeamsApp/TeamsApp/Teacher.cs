using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamsApp
{
    public class Teacher
    {
        [Key]
        public int idteacher { get; set; }
        public string firstnameteacher { get; set; }
        public int lastNameteacher { get; set; }

    }
}
