using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    [Serializable()]
    public partial class IsoscelesTriangle : Form
    {
        public static double sideA;
        public static double sideB;

        public IsoscelesTriangle()
        {
            InitializeComponent();
        }

        private void btnDescribe_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtBoxA.Text) + Convert.ToDouble(txtBoxA.Text) <= Convert.ToDouble(txtBoxB.Text) || Convert.ToDouble(txtBoxA.Text) + Convert.ToDouble(txtBoxB.Text) <= Convert.ToDouble(txtBoxA.Text))
                {
                    MessageBox.Show("Invalid values!");
                }
                else
                {
                    Project.Lib.IsoscelesTriangle isoscelesTriangle = new Project.Lib.IsoscelesTriangle(Convert.ToDouble(txtBoxA.Text), Convert.ToDouble(txtBoxB.Text));
                    lblDescribe.Text = isoscelesTriangle.Describe();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the parameters of the isosceles triangle!");
            }
        }

        private void btnCalcArea_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtBoxA.Text) + Convert.ToDouble(txtBoxA.Text) <= Convert.ToDouble(txtBoxB.Text) || Convert.ToDouble(txtBoxA.Text) + Convert.ToDouble(txtBoxB.Text) <= Convert.ToDouble(txtBoxA.Text))
                {
                    MessageBox.Show("Invalid values!");
                }
                else
                {
                    Project.Lib.IsoscelesTriangle isoscelesTriangle = new Project.Lib.IsoscelesTriangle(Convert.ToDouble(txtBoxA.Text), Convert.ToDouble(txtBoxB.Text));
                    lblCalcArea.Text = "The area of the isosceles triangle is " + isoscelesTriangle.CalculateArea();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the parameters of the isosceles triangle!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Triangle triangle = new Triangle();
            triangle.Show();
        }

        private void btnCalcPerimeter_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtBoxA.Text) + Convert.ToDouble(txtBoxA.Text) <= Convert.ToDouble(txtBoxB.Text) || Convert.ToDouble(txtBoxA.Text) + Convert.ToDouble(txtBoxB.Text) <= Convert.ToDouble(txtBoxA.Text))
                {
                    MessageBox.Show("Invalid values!");
                }
                else
                {
                    Project.Lib.IsoscelesTriangle isoscelesTriangle = new Project.Lib.IsoscelesTriangle(Convert.ToDouble(txtBoxA.Text), Convert.ToDouble(txtBoxB.Text));
                    lblCalcPerimeter.Text = "The perimeter of the isosceles triangle is " + isoscelesTriangle.CalculatePerimeter();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the parameters of the isosceles triangle!");
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxA.Clear();
            txtBoxB.Clear();
            lblDescribe.Text = "";
            lblCalcArea.Text = "";
            lblCalcPerimeter.Text = "";
        }

        private void btnDrawing_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtBoxA.Text) + Convert.ToDouble(txtBoxA.Text) <= Convert.ToDouble(txtBoxB.Text) || Convert.ToDouble(txtBoxA.Text) + Convert.ToDouble(txtBoxB.Text) <= Convert.ToDouble(txtBoxA.Text))
                {
                    MessageBox.Show("Invalid values!");
                }
                else
                {
                    sideA = Convert.ToDouble(txtBoxA.Text);
                    sideB = Convert.ToDouble(txtBoxB.Text);
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
