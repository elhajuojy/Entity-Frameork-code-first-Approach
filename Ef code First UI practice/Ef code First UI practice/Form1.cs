using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Ef_code_First_UI_practice.Models;

namespace Ef_code_First_UI_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CeContext _db = new CeContext();
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.CompanyID= int.Parse(textid.Text);
            company.CNAME=textnom.Text;
            company.ADDRESS=textAdresse.Text;
            
            _db.Companys.Add(company);
            _db.SaveChanges();

            MessageBox.Show("succeed ");
        }
    }
}
