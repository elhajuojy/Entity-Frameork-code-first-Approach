using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestContext_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        teacherContext11 _db = new teacherContext11();
        private void Form1_Load(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.idteacher = 1;
            t.firstnameteacher = "mehdi";

            _db.teachers.Add(t);

        }
    }
}
