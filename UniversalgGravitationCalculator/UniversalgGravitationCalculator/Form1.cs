using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UniversalgGravitationCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Welcome to Universal Gravitation Equation", "Universal Gravitation");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double m1, m2, r;
            
            m1 = Convert.ToDouble(txtM1.Text);
            m2 = Convert.ToDouble(txtM2.Text);
            r = Convert.ToDouble(txtR.Text);
            /* G= 6.67 * 10^(-11)
              Solving 10^(-11)
              5* Math.Pow(2,-11) == 10^(-11)
             */
            
            double i = 6.67, x = 5* Math.Pow(2, -11);
            double G = (i * x);
            double f1, f2;

// display the formula
            lblFormula.Text = "F = G * M1 * M2/ r*r";
// display G * M * m           
            f1 = G * m1 * m2;
            lblF1.Text ="F = "+i+ " * 10^-11 "+ " * " + m1 + " * "+ m2;
      
//display f1 * (r*r)
            lblF2.Text ="F = "+ f1 + " N \n       --------------------------- \n              " +(r+" * "+r);
//final answer
            f2 = f1 / (r * r);
            lblForce.Text ="Force = "+f2+ " N";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
