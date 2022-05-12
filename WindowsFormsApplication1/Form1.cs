using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using ClassLibrary2;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static List<Point> points;
        public static List<Shape> openedProject;

        public Form1()
        {
            InitializeComponent();
            points = new List<Point>(5);
            openedProject = new List<Shape>();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics Space = e.Graphics;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var p = new Dot(points.Last().X, points.Last().Y);
            p.Draw(this.CreateGraphics(), new Pen(Color.Black));
            openedProject.Add(p);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var p = new Line(points.Last().X, points.Last().Y, points[points.Count - 2].X,
                points[points.Count - 2].Y);
            p.Draw(this.CreateGraphics(), new Pen(Color.Black));
            openedProject.Add(p);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var p = new Ellipse(points[points.Count - 2].X, points[points.Count - 2].Y,
                Math.Abs(points.Last().X - points[points.Count - 2].X),
                Math.Abs(points.Last().Y - points[points.Count - 2].Y));

            p.Draw(this.CreateGraphics(), new Pen(Color.Black));
            openedProject.Add(p);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var p = new Triangle(points.Last().X, points.Last().Y,
                points[points.Count - 2].X, points[points.Count - 2].Y,
                points[points.Count - 3].X, points[points.Count - 3].Y);
            p.Draw(this.CreateGraphics(), new Pen(Color.Black));
            openedProject.Add(p);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var p = new Rectangle(points[points.Count - 2].X, points[points.Count - 2].Y,
                Math.Abs(points.Last().X - points[points.Count - 2].X),
                Math.Abs(points.Last().Y - points[points.Count - 2].Y));
            p.Draw(this.CreateGraphics(), new Pen(Color.Black));
            openedProject.Add(p);
        }

        private void drawPolygon_Click(object sender, EventArgs e)
        {
            var p = new Polygon(points.Last().X, points.Last().Y,
                points[points.Count - 2].X, points[points.Count - 2].Y,
                points[points.Count - 3].X, points[points.Count - 3].Y,
                points[points.Count - 4].X, points[points.Count - 4].Y,
                points[points.Count - 5].X, points[points.Count - 5].Y);
            p.Draw(this.CreateGraphics(), new Pen(Color.Black));
            openedProject.Add(p);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (Stream stream = File.Open("data.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, openedProject);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error while writing to file");
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (Stream stream = File.Open("data.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    openedProject = (List<Shape>) bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error while reading file");
            }

            foreach (var item in openedProject)
            {
                item.Draw(CreateGraphics(), new Pen(Color.Black));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var types = typeof(Trapezium.Trapezium).Assembly.GetTypes();
                foreach (var item in types)
                {
                    if (item.BaseType == typeof(Shape))
                        comboBox1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading assembly");
            }
        }

        private void btnDrawCombo_Click(object sender, EventArgs e)
        {
            var g = Activator.CreateInstance((Type) comboBox1.SelectedItem, new object[]
            {
                points.Last().X, points.Last().Y,
                points[points.Count - 2].X, points[points.Count - 2].Y
            }) as Shape;
            openedProject.Add(g);
            if (g != null)
                g.Draw(CreateGraphics(), new Pen(Color.Black));
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            var click = new Point(PointToClient(MousePosition).X, PointToClient(MousePosition).Y);
            points.Add(click);
            textBox1.Select(0, 0);
            textBox1.SelectedText += "X:" + click.X + " Y:" + click.Y + Environment.NewLine;
            switch (points.Count)
            {
                case 1:
                {
                    drawDot.Enabled = true;
                    break;
                }
                case 2:
                {
                    drawLine.Enabled = true;
                    drawEllipse.Enabled = true;
                    drawRectangle.Enabled = true;
                    break;
                }
                case 3:
                {
                    drawTriangle.Enabled = true;
                    break;
                }
                case 5:
                {
                    drawPolygon.Enabled = true;
                    break;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            points.Clear();
            drawDot.Enabled = false;
            drawEllipse.Enabled = false;
            drawLine.Enabled = false;
            drawRectangle.Enabled = false;
            drawTriangle.Enabled = false;
            drawPolygon.Enabled = false;
            textBox1.Clear();
        }
    }
}