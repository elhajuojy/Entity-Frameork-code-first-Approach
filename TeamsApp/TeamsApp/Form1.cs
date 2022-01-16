using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           techerStudentContext _db = new techerStudentContext();

            Student st = new Student();
            st.Id = 1;
            st.NameStudent = "mehdi elhjuojy";
            st.StudentAge = 22;
            st.idteacher = 1;
            _db.Students.Add(st);
            _db.Students.Remove(st);
            _db.Students.Find(1);
            _db.SaveChanges();



            



        }
    }
}
