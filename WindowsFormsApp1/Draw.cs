using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WindowsFormsApp1
{
    [Serializable()]
    public partial class Draw : Form
    {
        private bool btnRectWasClicked = false;
        private bool btnSquareWasClicked = false;
        private bool btnCircleWasClicked = false;
        private bool btnEquiateralTriangleWasClicked = false;
        private bool btnIsoscelesTriangleWasClicked = false;
        private bool btnScaleneTriangleWasClicked = false;

        public Draw()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        Pen p = new Pen(Color.Black);
        Graphics g;

        List<Project.Lib.IShape> shapes = new List<Project.Lib.IShape>();

        Point p1;

        bool getp1 = false;

        private void btnSquare_Click(object sender, EventArgs e)
        {
            if (Square.sideA == 0)
            {
                MessageBox.Show("Enter a value for the side of the square!");
                return;
            }
            g.DrawRectangle(p, p1.X, p1.Y, (float)Square.sideA * 10, (float)Square.sideA * 10);
            btnSquareWasClicked = true;
            Project.Lib.Square square = new Project.Lib.Square(Square.sideA);
            shapes.Add(square);
            btnRectWasClicked = false;
            btnCircleWasClicked = false;
            btnEquiateralTriangleWasClicked = false;
            btnIsoscelesTriangleWasClicked = false;
            btnScaleneTriangleWasClicked = false;
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            if (Rectangle.sideA == 0 || Rectangle.sideB == 0)
            {
                MessageBox.Show("Enter values for the parameter of the rectangle!");
                return;
            }
            g.DrawRectangle(p, p1.X, p1.Y, (float)Rectangle.sideA * 10, (float)Rectangle.sideB * 10);
            btnRectWasClicked = true;
            Project.Lib.Rectangle rectangle = new Project.Lib.Rectangle(Rectangle.sideA, Rectangle.sideB);
            shapes.Add(rectangle);
            btnSquareWasClicked = false;
            btnCircleWasClicked = false;
            btnEquiateralTriangleWasClicked = false;
            btnIsoscelesTriangleWasClicked = false;
            btnScaleneTriangleWasClicked = false;
        }

        private void DrawQuadrilateral_MouseDown(object sender, MouseEventArgs e)
        {
            Draw drawQuadrilateral = new Draw();
            drawQuadrilateral.Cursor = Cursors.Cross;
            getp1 = true;
            if (getp1)
            {
                p1 = new Point(e.X, e.Y);
            }
            getp1 = false;

            drawQuadrilateral.Cursor = Cursors.Default;
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            clrDialog.ShowDialog();
            SolidBrush sb = new SolidBrush(clrDialog.Color);
            if (btnRectWasClicked)
            {
                g.FillRectangle(sb, p1.X, p1.Y, (float)Rectangle.sideA * 10, (float)Rectangle.sideB * 10);
                btnRectWasClicked = false;
            }
            if (btnSquareWasClicked)
            {
                g.FillRectangle(sb, p1.X, p1.Y, (float)Square.sideA * 10, (float)Square.sideA * 10);
                btnSquareWasClicked = false;
            }
            if (btnCircleWasClicked)
            {
                g.FillEllipse(sb, p1.X, p1.Y, (float)Circle.R * 10, (float)Circle.R * 10);
                btnCircleWasClicked = false;
            }
            if (btnEquiateralTriangleWasClicked)
            {
                var side = Convert.ToInt32(EquilateralTriangle.sideA) * 10;
                Point[] points = new Point[] { new Point(p1.X, p1.Y), new Point(p1.X + side, p1.Y + side + side / 2), new Point(p1.X - side, p1.Y + side + side / 2) };
                g.FillPolygon(sb, points);
                btnEquiateralTriangleWasClicked = false;
            }
            if (btnIsoscelesTriangleWasClicked)
            {
                var sideA = Convert.ToInt32(IsoscelesTriangle.sideA) * 10;
                var sideB = Convert.ToInt32(IsoscelesTriangle.sideB) * 10;
                Point[] points = new Point[] { new Point(p1.X, p1.Y), new Point(p1.X + sideB, p1.Y + sideA), new Point(p1.X - sideB, p1.Y + sideA) };
                g.FillPolygon(sb, points);
                btnIsoscelesTriangleWasClicked = false;
            }
            if (btnScaleneTriangleWasClicked)
            {
                var sideA = Convert.ToInt32(ScaleneTriangle.sideA) * 10;
                var sideB = Convert.ToInt32(ScaleneTriangle.sideB) * 10;
                var sideC = Convert.ToInt32(ScaleneTriangle.sideC) * 10;
                Point[] points = new Point[] { new Point(p1.X, p1.Y), new Point(p1.X + sideB, p1.Y + sideA), new Point(p1.X - sideC, p1.Y + sideB) };
                g.FillPolygon(sb, points);
                btnScaleneTriangleWasClicked = false;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Shapes shapes = new Shapes();
            shapes.Show();
        }

        private void btnLINQ_Click(object sender, EventArgs e)
        {
            var smallShapes = shapes.Where(c => c.CalculatePerimeter() < 20).OrderBy(p => p.CalculatePerimeter()).ThenBy(c => c.CalculateArea()).Select(c => "Perimeter of " + c.GetName() + " is " + c.CalculatePerimeter() + ".Area of " + c.GetName() + " is " + c.CalculateArea()).ToList();
            foreach (var smallShape in smallShapes)
            {
                listBox1.Items.Add(smallShape);
            }
            var allPerimeter = shapes.Sum(c => c.CalculatePerimeter());
            listBox1.Items.Add(Environment.NewLine + "All shapes perimeter is " + allPerimeter);
        }

        private void drawCircle_Click(object sender, EventArgs e)
        {
            if (Circle.R == 0)
            {
                MessageBox.Show("Enter a value for the radius of the circle!");
                return;
            }

            g.DrawEllipse(p, p1.X, p1.Y, (float)Circle.R * 10, (float)Circle.R * 10);
            btnCircleWasClicked = true;
            Project.Lib.Circle circle = new Project.Lib.Circle(Circle.R);
            shapes.Add(circle);
            btnRectWasClicked = false;
            btnSquareWasClicked = false;
            btnEquiateralTriangleWasClicked = false;
            btnIsoscelesTriangleWasClicked = false;
            btnScaleneTriangleWasClicked = false;
        }

        private void btnTriag_Click(object sender, EventArgs e)
        {
            if (EquilateralTriangle.sideA == 0)
            {
                MessageBox.Show("Enter a value for the sides of the equilateral triangle!");
                return;
            }

            var side = Convert.ToInt32(EquilateralTriangle.sideA) * 10;
            Point[] points = new Point[] { new Point(p1.X, p1.Y), new Point(p1.X + side, p1.Y + side + side / 2), new Point(p1.X - side, p1.Y + side + side / 2) };
            g.DrawPolygon(p, points);
            btnEquiateralTriangleWasClicked = true;
            Project.Lib.EquilateralTriangle equilateralTriangle = new Project.Lib.EquilateralTriangle(EquilateralTriangle.sideA);
            shapes.Add(equilateralTriangle);
            btnRectWasClicked = false;
            btnSquareWasClicked = false;
            btnCircleWasClicked = false;
            btnIsoscelesTriangleWasClicked = false;
            btnScaleneTriangleWasClicked = false;
        }

        private void btnDrawIsoscelesTriag_Click(object sender, EventArgs e)
        {
            if (IsoscelesTriangle.sideA == 0 || IsoscelesTriangle.sideB == 0)
            {
                MessageBox.Show("Enter a value for the sides of the isosceles triangle!");
                return;
            }

            var sideA = Convert.ToInt32(IsoscelesTriangle.sideA) * 10;
            var sideB = Convert.ToInt32(IsoscelesTriangle.sideB) * 10;
            Point[] points = new Point[] { new Point(p1.X, p1.Y), new Point(p1.X + sideB, p1.Y + sideA), new Point(p1.X - sideB, p1.Y + sideA) };
            g.DrawPolygon(p, points);
            btnIsoscelesTriangleWasClicked = true;
            Project.Lib.IsoscelesTriangle isoscelesTriangle = new Project.Lib.IsoscelesTriangle(IsoscelesTriangle.sideA, IsoscelesTriangle.sideB);
            shapes.Add(isoscelesTriangle);
            btnRectWasClicked = false;
            btnSquareWasClicked = false;
            btnCircleWasClicked = false;
            btnEquiateralTriangleWasClicked = false;
            btnScaleneTriangleWasClicked = false;
        }

        private void btnDrawScaleneTriag_Click(object sender, EventArgs e)
        {
            if (ScaleneTriangle.sideA == 0 || ScaleneTriangle.sideB == 0 || ScaleneTriangle.sideC == 0)
            {
                MessageBox.Show("Enter a value for the sides of the scalene triangle!");
                return;
            }

            var sideA = Convert.ToInt32(ScaleneTriangle.sideA) * 10;
            var sideB = Convert.ToInt32(ScaleneTriangle.sideB) * 10;
            var sideC = Convert.ToInt32(ScaleneTriangle.sideC) * 10;
            Point[] points = new Point[] { new Point(p1.X, p1.Y), new Point(p1.X + sideB, p1.Y + sideA), new Point(p1.X - sideC, p1.Y + sideB) };
            g.DrawPolygon(p, points);
            btnScaleneTriangleWasClicked = true;
            Project.Lib.ScaleneTriangle scaleneTriangle = new Project.Lib.ScaleneTriangle(ScaleneTriangle.sideA, ScaleneTriangle.sideB, ScaleneTriangle.sideC);
            shapes.Add(scaleneTriangle);
            btnRectWasClicked = false;
            btnSquareWasClicked = false;
            btnCircleWasClicked = false;
            btnEquiateralTriangleWasClicked = false;
            btnIsoscelesTriangleWasClicked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write))
                {
                    formatter.Serialize(stream, shapes);
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                {
                    shapes = (List<Project.Lib.IShape>)formatter.Deserialize(stream);
                }
            }
        }
    }
}
