using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        private Figure[] figures;
        private Bitmap canvas;

        public Form1()
        {
            InitializeComponent();
            canvas = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = canvas;
            comboType.SelectedIndex = 0;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(canvas);
            g.Clear(Color.White);

            int count = (int)numCount.Value;
            figures = new Figure[count];

            for (int i = 0; i < count; i++)
            {
                int x = rand.Next(10, pictureBox.Width - 60);
                int y = rand.Next(10, pictureBox.Height - 60);
                int w = rand.Next(30, 60);
                int h = rand.Next(30, 60);
                Color color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

                switch (comboType.SelectedItem.ToString())
                {
                    case "Square":
                        figures[i] = new Square(x, y, w, color);
                        break;
                    case "Rectangle":
                        figures[i] = new RectangleFigure(x, y, w, h, color);
                        break;
                    case "Ellipse":
                        figures[i] = new EllipseFigure(x, y, w, h, color);
                        break;
                    case "Rhombus":
                        figures[i] = new RhombusFigure(x, y, w, h, color);
                        break;
                }

                figures[i].Draw(g);
            }

            pictureBox.Refresh();
        }
    }

    // Абстрактний базовий клас
    public abstract class Figure
    {
        protected int x, y, width, height;
        protected Color color;

        public Figure(int x, int y, int width, int height, Color color)
        {
            this.x = x; this.y = y;
            this.width = width; this.height = height;
            this.color = color;
        }

        public abstract void Draw(Graphics g);

        public virtual void Move(int dx, int dy)
        {
            x += dx;
            y += dy;
        }
    }

    // Похідні класи
    public class Square : Figure
    {
        public Square(int x, int y, int size, Color color)
            : base(x, y, size, size, color) { }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color))
            {
                g.DrawRectangle(pen, x, y, width, height);
            }
        }
    }

    public class RectangleFigure : Figure
    {
        public RectangleFigure(int x, int y, int width, int height, Color color)
            : base(x, y, width, height, color) { }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color))
            {
                g.DrawRectangle(pen, x, y, width, height);
            }
        }
    }

    public class EllipseFigure : Figure
    {
        public EllipseFigure(int x, int y, int width, int height, Color color)
            : base(x, y, width, height, color) { }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color))
            {
                g.DrawEllipse(pen, x, y, width, height);
            }
        }
    }

    public class RhombusFigure : Figure
    {
        public RhombusFigure(int x, int y, int width, int height, Color color)
            : base(x, y, width, height, color) { }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color))
            {
                Point[] points = new Point[]
                {
                    new Point(x + width / 2, y),
                    new Point(x + width, y + height / 2),
                    new Point(x + width / 2, y + height),
                    new Point(x, y + height / 2)
                };
                g.DrawPolygon(pen, points);
            }
        }
    }
}
