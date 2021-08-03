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
    public partial class Square : Form
    {
        public static double sideA;

        public Square()
        {
            InitializeComponent();
        }

        private void btnCalcPerimeter_Click(object sender, EventArgs e)
        {
            try
            {
                Project.Lib.Square square = new Project.Lib.Square(Convert.ToDouble(txtBoxA.Text));
                lblCalcPerimeter.Text = "The perimeter of the square is " + square.CalculatePerimeter();
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the parameters of the square!");
            }
        }

        private void btnDescribe_Click(object sender, EventArgs e)
        {
            try
            {
                Project.Lib.Square square = new Project.Lib.Square(Convert.ToDouble(txtBoxA.Text));
                lblDescribe.Text = square.Describe();
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the parameters of the square!");
            }
        }

        private void btnCalcArea_Click(object sender, EventArgs e)
        {
            try
            {
                Project.Lib.Square square = new Project.Lib.Square(Convert.ToDouble(txtBoxA.Text));
                lblCalcArea.Text = "The area of the square is " + square.CalculateArea();
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the parameters of the square!");
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxA.Clear();
            lblDescribe.Text = "";
            lblCalcArea.Text = "";
            lblCalcPerimeter.Text = "";
        }

        private void btnDrawing_Click(object sender, EventArgs e)
        {
            try
            {
                sideA = Convert.ToDouble(txtBoxA.Text);
                Draw draw = new Draw();
                draw.Show();
                this.Hide();
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the parameters of the square!");
            }
        }
    }
}
