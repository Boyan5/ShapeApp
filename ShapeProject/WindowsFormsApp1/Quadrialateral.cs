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
    public partial class Quadrialateral : Form
    {
        public Quadrialateral()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {           
            if (radButRectangle.Checked)
            {
                Rectangle rectangle = new Rectangle();
                rectangle.Show();
                this.Hide();
            }

            else
            {
                Square square = new Square();
                square.Show();
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
