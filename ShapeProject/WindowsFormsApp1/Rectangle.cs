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
    public partial class Rectangle : Form
    {
        public static double sideA;
        public static double sideB;

        public Rectangle()
        {
            InitializeComponent();
        }

        private void btnDescribe_Click(object sender, EventArgs e)
        {
            try
            {
                Project.Lib.Rectangle rectangle = new Project.Lib.Rectangle(Convert.ToDouble(txtBoxA.Text), Convert.ToDouble(txtBoxB.Text));
                lblDescribe.Text = rectangle.Describe();
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the parameters of the rectangle!");
            }
        }

        private void btnCalcArea_Click(object sender, EventArgs e)
        {
            try
            {
                Project.Lib.Rectangle rectangle = new Project.Lib.Rectangle(Convert.ToDouble(txtBoxA.Text), Convert.ToDouble(txtBoxB.Text));
                lblCalcArea.Text = "The area of the rectangle is " + rectangle.CalculateArea();
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the parameters of the rectangle!");
            }
        }

        private void btnCalcPerimeter_Click(object sender, EventArgs e)
        {
            try
            {
                Project.Lib.Rectangle rectangle = new Project.Lib.Rectangle(Convert.ToDouble(txtBoxA.Text), Convert.ToDouble(txtBoxB.Text));
                lblCalcPerimeter.Text = "The perimeter of the rectangle is " + rectangle.CalculatePerimeter();
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the parameters of the rectangle!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {      
            this.Close();
            Quadrialateral quadrialateral = new Quadrialateral();
            quadrialateral.Show();
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
                sideA = Convert.ToDouble(txtBoxA.Text);
                sideB = Convert.ToDouble(txtBoxB.Text);
                Draw draw = new Draw();
                draw.Show();
                this.Hide();
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the parameters of the rectangle!");
            }
        }
    }
}
