﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;


namespace TestContext_
{
    public class Teacher
    {
        [Key]
        public int idteacher { get; set; }
        public string firstnameteacher { get; set; }
        public int lastNameteacher { get; set; }
    }
}
