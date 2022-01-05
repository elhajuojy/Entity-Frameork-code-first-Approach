using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_code_First_Approach_project_Practice.Models
{
    public class Employee
    {
        public Employee()
        {

        }
        public int Employeeid { get; set; } 
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public  int CompanyID { get; set; }
    }
}
