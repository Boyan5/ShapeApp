using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Lib;

namespace WindowsFormsApp1
{
    [Serializable()]
    public partial class ScaleneTriangle : Form
    {
        public static double sideA;
        public static double sideB;
        public static double sideC;

        public ScaleneTriangle()
        {
            InitializeComponent();
        }

        private void btnDescribe_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtBoxA.Text) + Convert.ToDouble(txtBoxB.Text) <= Convert.ToDouble(txtBoxC.Text) || Convert.ToDouble(txtBoxA.Text) + Convert.ToDouble(txtBoxC.Text) <= Convert.ToDouble(txtBoxB.Text) || Convert.ToDouble(txtBoxB.Text) + Convert.ToDouble(txtBoxC.Text) <= Convert.ToDouble(txtBoxA.Text))
                {
                    MessageBox.Show("Invalid values!");
                }
                else
                {
                    Project.Lib.ScaleneTriangle scaleneTriangle = new Project.Lib.ScaleneTriangle(Convert.ToDouble(txtBoxA.Text), Convert.ToDouble(txtBoxB.Text), Convert.ToDouble(txtBoxC.Text));
                    lblDescribe.Text = scaleneTriangle.Describe();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the parameters of the scalene triangle!");
            }
        }

        private void btnCalcArea_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtBoxA.Text) + Convert.ToDouble(txtBoxB.Text) <= Convert.ToDouble(txtBoxC.Text) || Convert.ToDouble(txtBoxA.Text) + Convert.ToDouble(txtBoxC.Text) <= Convert.ToDouble(txtBoxB.Text) || Convert.ToDouble(txtBoxB.Text) + Convert.ToDouble(txtBoxC.Text) <= Convert.ToDouble(txtBoxA.Text))
                {
                    MessageBox.Show("Invalid values!");
                }
                else
                {
                    Project.Lib.ScaleneTriangle scaleneTriangle = new Project.Lib.ScaleneTriangle(Convert.ToDouble(txtBoxA.Text), Convert.ToDouble(txtBoxB.Text), Convert.ToDouble(txtBoxC.Text));
                    lblCalcArea.Text = "The area of the scalene triangle is " + scaleneTriangle.CalculateArea();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the parameters of the scalene triangle!");
            }
        }

        private void btnCalcPerimeter_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtBoxA.Text) + Convert.ToDouble(txtBoxB.Text) <= Convert.ToDouble(txtBoxC.Text) || Convert.ToDouble(txtBoxA.Text) + Convert.ToDouble(txtBoxC.Text) <= Convert.ToDouble(txtBoxB.Text) || Convert.ToDouble(txtBoxB.Text) + Convert.ToDouble(txtBoxC.Text) <= Convert.ToDouble(txtBoxA.Text))
                {
                    MessageBox.Show("Invalid values!");
                }
                else
                {
                    Project.Lib.ScaleneTriangle scaleneTriangle = new Project.Lib.ScaleneTriangle(Convert.ToDouble(txtBoxA.Text), Convert.ToDouble(txtBoxB.Text), Convert.ToDouble(txtBoxC.Text));
                    lblCalcPerimeter.Text = "The perimeter of the scalene triangle is " + scaleneTriangle.CalculatePerimeter();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the parameters of the scalene triangle!");
            }
        }

        private void txtBoxA_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtBoxB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtBoxC_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Triangle triangle = new Triangle();
            triangle.Show();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxA.Clear();
            txtBoxB.Clear();
            txtBoxC.Clear();
            lblDescribe.Text = "";
            lblCalcArea.Text = "";
            lblCalcPerimeter.Text = "";
        }

        private void btnDrawing_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtBoxA.Text) + Convert.ToDouble(txtBoxB.Text) <= Convert.ToDouble(txtBoxC.Text) || Convert.ToDouble(txtBoxA.Text) + Convert.ToDouble(txtBoxC.Text) <= Convert.ToDouble(txtBoxB.Text) || Convert.ToDouble(txtBoxB.Text) + Convert.ToDouble(txtBoxC.Text) <= Convert.ToDouble(txtBoxA.Text))
                {
                    MessageBox.Show("Invalid values!");
                }
                else
                {
                    sideA = Convert.ToDouble(txtBoxA.Text);
                    sideB = Convert.ToDouble(txtBoxB.Text);
                    sideC = Convert.ToDouble(txtBoxC.Text);
                    Draw draw = new Draw();
                    draw.Show();
                    this.Hide();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the parameters of the right triangle!");
            }
        }
    }
}
