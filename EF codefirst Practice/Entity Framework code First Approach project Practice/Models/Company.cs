using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_code_First_Approach_project_Practice.Models
{
    public class Company

    {
        public Company()
        {

        }
        public int CompanyID { get; set; }

        public string CNAME { get; set; }

        public string ADDRESS { get; set; }

    }
}
