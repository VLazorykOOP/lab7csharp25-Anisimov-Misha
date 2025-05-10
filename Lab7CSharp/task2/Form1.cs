using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GraphPlotter
{
    public partial class Form1 : Form
    {
        private float xMin = -2f;
        private float xMax = 2f;
        private float step = 0.05f;
        private float currentX;

        public Form1()
        {
            InitializeComponent();
            currentX = xMin;
            timer1.Interval = 50;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            using (Graphics g = panelGraph.CreateGraphics())
            {
                Pen pen = GetSelectedPen();

                float prevX = currentX;
                float prevY = Function(prevX);
                currentX += step;

                if (currentX > xMax)
                {
                    timer1.Stop();
                    return;
                }

                float y = Function(currentX);

                PointF p1 = ToScreenCoords(prevX, prevY);
                PointF p2 = ToScreenCoords(currentX, y);

                g.DrawLine(pen, p1, p2);
            }
        }

        private float Function(float x)
        {
            return (1 - x * x) * (x - 2);
        }

        private PointF ToScreenCoords(float x, float y)
        {
            float w = panelGraph.Width;
            float h = panelGraph.Height;
            float xScreen = (x - xMin) / (xMax - xMin) * w;
            float yScreen = h / 2 - y * 50;
            return new PointF(xScreen, yScreen);
        }

        private Pen GetSelectedPen()
        {
            Color color = rbRed.Checked ? Color.Red :
                          rbGreen.Checked ? Color.Green :
                          rbBlue.Checked ? Color.Blue : Color.Black;

            float width = rbThin.Checked ? 1 :
                          rbMedium.Checked ? 2 : 4;

            DashStyle style = rbSolid.Checked ? System.Drawing.Drawing2D.DashStyle.Solid :
                              rbDash.Checked ? System.Drawing.Drawing2D.DashStyle.Dash :
                              System.Drawing.Drawing2D.DashStyle.Dot;

            Pen pen = new Pen(color, width);
            pen.DashStyle = style;
            return pen;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            panelGraph.Refresh();
            DrawAxes();
            currentX = xMin;
            timer1.Start();
        }

        private void DrawAxes()
        {
            Graphics g = panelGraph.CreateGraphics();
            Pen axisPen = new Pen(Color.Gray, 1);

            // Y-axis
            g.DrawLine(axisPen, panelGraph.Width / 2, 0, panelGraph.Width / 2, panelGraph.Height);

            // X-axis
            g.DrawLine(axisPen, 0, panelGraph.Height / 2, panelGraph.Width, panelGraph.Height / 2);
        }
    }
}
