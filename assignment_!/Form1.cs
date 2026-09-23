using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            // store student inputs into variable
            String studentName = txtname.Text;
            String studentid = txtstudentid.Text;
            String studentdepartment = txtdepartment.Text;
            String studentsemester = txtsemester.Text;

            // displaying the output
            lbloutput.Text = studentName + " : " + studentid + " : " + studentdepartment + " : " + studentsemester;   


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // clear the textbox
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();
        }
    }
}
