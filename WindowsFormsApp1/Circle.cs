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
    public partial class Circle : Form
    {
        public static double R;
        public Circle()
        {
            InitializeComponent();
        }

        private void btnDescribe_Click(object sender, EventArgs e)
        {
            try
            {
                Project.Lib.Circle circle = new Project.Lib.Circle(Convert.ToDouble(txtBoxR.Text));
                lblDescribe.Text = circle.Describe();
            }
            catch (FormatException)
            {
                MessageBox.Show("Value for R is not entered!");
            }
        }

        private void btnCalcArea_Click(object sender, EventArgs e)
        {
            try
            {
                Project.Lib.Circle circle = new Project.Lib.Circle(Convert.ToDouble(txtBoxR.Text));
                lblCalcArea.Text = "The area of the circle is " + circle.CalculateArea();
            }
            catch (FormatException)
            {
                MessageBox.Show("Value for R is not entered!");
            }
        }

        private void btnCalcPerimeter_Click(object sender, EventArgs e)
        {
            try
            {
                Project.Lib.Circle circle = new Project.Lib.Circle(Convert.ToDouble(txtBoxR.Text));
                lblCalcPerimeter.Text = "The perimeter of the circle is " + circle.CalculatePerimeter();
            }
            catch (FormatException)
            {
                MessageBox.Show("Value for R is not entered!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Shapes shapes = new Shapes();
            shapes.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxR.Clear();
            lblDescribe.Text = "";
            lblCalcArea.Text = "";
            lblCalcPerimeter.Text = "";
        }

        private void txtBoxR_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                R = Convert.ToDouble(txtBoxR.Text);
                Draw draw = new Draw();
                draw.Show();
                this.Hide();
            }
            catch (FormatException)
            {
                MessageBox.Show("Value for R is not entered!");
            }
        }
    }
}
