using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Triangle : Form
    {
        public Triangle()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {           
            if (radbutScalTriag.Checked)
            {
                ScaleneTriangle scaleneTriangle = new ScaleneTriangle();
                scaleneTriangle.Show();
                this.Hide();
            }

            else if (radbutIsoTriag.Checked)
            {
                IsoscelesTriangle isoscelesTriangle = new IsoscelesTriangle();
                isoscelesTriangle.Show();
                this.Hide();
            }

            else
            {
                EquilateralTriangle equilateralTriangle = new EquilateralTriangle();
                equilateralTriangle.Show();
                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Shapes shapes = new Shapes();
            shapes.Show();
        }
    }
}
