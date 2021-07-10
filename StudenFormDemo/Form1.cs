using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudenFormDemo
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void lblScores_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String major = "TBH";
            if(rbProgramming.Checked)
            {
                major = rbProgramming.Text;
            } else if (rbWebDesign.Checked)
            {
                major = rbWebDesign.Text;
            } else if (rbIT.Checked)
            {
                major = rbIT.Text;
            }



        }

        private void txbStudentID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
