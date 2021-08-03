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
    public partial class Shapes : Form
    {
        public Shapes()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (radbutTriangle.Checked)
            {
                Triangle triangle = new Triangle();
                triangle.Show();
                this.Hide();
            }

            else if (radbutQuadrilateral.Checked)
            {
                Quadrialateral quadrialateral = new Quadrialateral();
                quadrialateral.Show();
                this.Hide();
            }

            else
            {
                Circle circle = new Circle();
                circle.Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
