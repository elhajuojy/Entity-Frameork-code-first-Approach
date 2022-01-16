using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_code_First_UI_practice.Models
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

        public DateTime HireDate { get; set; }

        public decimal salary { get; set; }

        public string job { get; set; }
        
        public int CompanyID { get; set; }
    }
}
