using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace matmetmot
{
    public partial class Form1 : Form
    {
        private bool shouldRedraw = true;

        private List<GraphicsPath> paths = new List<GraphicsPath>();
        private List<string> labels = new List<string>();
        private List<Color> colors = new List<Color>();

        public Form1()
        {
            InitializeComponent();
            pictureBox.BackColor = Color.White;
            CenterPictureBox();
            InitializeConstraints();
            DrawLegend();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var pan in this.Controls.OfType<Panel>())
            {
                pan.Location = new Point(0, 0);
                pan.Visible = false;
            }
            this.Size = new System.Drawing.Size(panel1.Size.Width + 15, panel1.Size.Height + 40);
            panel1.Visible = true;
            this.Text = "МЕНЮ";

            dataGridView1.Rows.Add(); dataGridView1.Rows.Add(); dataGridView1.Rows.Add();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var pan in this.Controls.OfType<Panel>())
            {
                pan.Visible = false;
            }
            this.Size = new System.Drawing.Size(panel2.Size.Width + 15, panel2.Size.Height + 40);
            panel2.Visible = true;
            this.Text = "ЗАДАНИЕ 1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var pan in this.Controls.OfType<Panel>())
            {
                pan.Visible = false;
            }
            this.Size = new System.Drawing.Size(panel3.Size.Width + 15, panel3.Size.Height + 40);
            panel3.Visible = true;
            this.Text = "ЗАДАНИЕ 2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var pan in this.Controls.OfType<Panel>())
            {
                pan.Visible = false;
            }
            this.Size = new System.Drawing.Size(panel4.Size.Width + 15, panel4.Size.Height + 40);
            panel4.Visible = true;
            this.Text = "ЗАДАНИЕ 3";
        }

        private void getBackToMainMenu()
        {
            foreach (var pan in this.Controls.OfType<Panel>())
            {
                pan.Location = new Point(0, 0);
                pan.Visible = false;
            }
            this.Size = new System.Drawing.Size(panel1.Size.Width + 15, panel1.Size.Height + 40);
            panel1.Visible = true;
            this.Text = "МЕНЮ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getBackToMainMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            getBackToMainMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            getBackToMainMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string solvePart1 = "Время:";
            string solvePart2 = "План:";
            string solvePart3 = "Также:";
            string solvePart4 = "Фунция:";

            string result = "";

            result += solvePart1 + "\n"; //Время
            result += String.Format("X(1a) + X(1b) + X(1с) <= {0}", textBox1.Text) + "\n";
            result += String.Format("X(1a) + X(1b) + X(1с) <= {0}", textBox1.Text) + "\n";
            result += solvePart2 + "\n"; //План
            result += String.Format("{0}X(1a) + {1}X(2a) >= {2}", dataGridView1.Rows[0].Cells[0].Value, dataGridView1.Rows[0].Cells[1].Value, dataGridView1.Rows[0].Cells[4].Value) + "\n";
            result += String.Format("{0}X(1b) + {1}X(2b) >= {2}", dataGridView1.Rows[1].Cells[0].Value, dataGridView1.Rows[1].Cells[1].Value, dataGridView1.Rows[1].Cells[4].Value) + "\n";
            result += String.Format("{0}X(1c) + {1}X(2c) >= {2}", dataGridView1.Rows[2].Cells[0].Value, dataGridView1.Rows[2].Cells[1].Value, dataGridView1.Rows[2].Cells[4].Value) + "\n";
            result += solvePart3 + "\n"; //Также
            result += String.Format("X(1a), X(1b), X(1с) >= 0") + "\n";
            result += String.Format("X(2a), X(2b), X(2b) >= 0") + "\n";
            result += solvePart4 + "\n"; //Функция
            result += String.Format("{0}X(1a) + {1}X(1b) + {2}X(1с) + {3}X(2a) + {4}X(2b) + {5}X(2b) = min", dataGridView1.Rows[0].Cells[2].Value, dataGridView1.Rows[1].Cells[2].Value, dataGridView1.Rows[2].Cells[2].Value, dataGridView1.Rows[0].Cells[3].Value, dataGridView1.Rows[1].Cells[3].Value, dataGridView1.Rows[2].Cells[3].Value) + "\n";

            label1.Text = result;
        }

        private void CenterPictureBox()
        {
            int x = (pictureBox.Width - pictureBox.DisplayRectangle.Width) / 2;
            int y = (pictureBox.Height - pictureBox.DisplayRectangle.Height) / 2;
            pictureBox.Location = new Point(x, y);
        }

        private void InitializeConstraints()
        {
            // Ограничения
            AddConstraint(6, 27, 1152, Color.Blue, "6x1 + 27x2 >= 1152");
            AddConstraint(-18, -9, -1296, Color.Red, "-18x1 - 9x2 >= -1296");
            AddConstraint(6, -27, -1008, Color.Green, "6x1 - 27x2 >= -1008");
            AddConstraint(-6, -9, -504, Color.Purple, "-6x1 - 9x2 <= -504");
        }

        private void AddConstraint(int a, int b, int c, Color color, string label)
        {
            GraphicsPath path = new GraphicsPath();
            Pen pen = new Pen(color, 2);

            int x1 = 0;
            int x2 = pictureBox.Width;

            int y1 = (int)((c - a * x1) / (double)b);
            int y2 = (int)((c - a * x2) / (double)b);

            path.AddLine(x1, y1, x2, y2);
            paths.Add(path);
            labels.Add(label);
            colors.Add(color);

            pen.Dispose();
        }

        private void DrawConstraints(Graphics g)
        {
            for (int i = 0; i < paths.Count; i++)
            {
                using (Pen pen = new Pen(colors[i], 2))
                {
                    g.DrawPath(pen, paths[i]);

                    // Добавим метку к линии
                    Font font = new Font("Arial", 8);
                    Brush brush = new SolidBrush(colors[i]);
                    g.DrawString(labels[i], font, brush, new Point(pictureBox.Width - 150, i * 20));
                    font.Dispose();
                    brush.Dispose();
                }
            }

            // Отмечаем область допустимых решений
            DrawFeasibleRegion(g);
        }

        private void DrawFeasibleRegion(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush brush = new SolidBrush(Color.FromArgb(50, Color.Gray));

            int x1 = 0;
            int x2 = pictureBox.Width;
            int y1 = 0;
            int y2 = pictureBox.Height;

            g.FillPolygon(brush, new Point[] { new Point(x1, y1), new Point(x2, y1), new Point(x2, y2), new Point(x1, y2) });
            g.DrawPolygon(pen, new Point[] { new Point(x1, y1), new Point(x2, y1), new Point(x2, y2), new Point(x1, y2) });

            pen.Dispose();
            brush.Dispose();
        }

        private void DrawLegend()
        {
            Graphics g = pictureBox.CreateGraphics();
            Font font = new Font("Arial", 10);

            int legendX = 10;  // Позиция X для легенды
            int legendY = pictureBox.Height - 120;  // Позиция Y для легенды
            int legendWidth = 180;
            int legendHeight = 100;

            // Рисуем белый прямоугольник для фона легенды
            g.FillRectangle(Brushes.White, legendX, legendY, legendWidth, legendHeight);

            g.DrawString("Legend", font, Brushes.Black, new Point(legendX + 10, legendY + 10));

            for (int i = 0; i < paths.Count; i++)
            {
                int itemX = legendX + 20;
                int itemY = legendY + 40 + i * 20;

                // Рисуем белый фон для каждого элемента легенды
                g.FillRectangle(Brushes.White, itemX, itemY, 20, 20);

                g.FillRectangle(new SolidBrush(colors[i]), itemX, itemY, 20, 20);
                g.DrawString(labels[i], font, Brushes.Black, new Point(itemX + 30, itemY));
            }

            font.Dispose();
            g.Dispose();
        }

        private void DrawAxes(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);

            // Ось X
            g.DrawLine(pen, 0, pictureBox.Height / 2, pictureBox.Width, pictureBox.Height / 2);
            g.DrawString("X", new Font("Arial", 12), Brushes.Black, new Point(pictureBox.Width - 20, pictureBox.Height / 2 - 20));

            // Ось Y
            g.DrawLine(pen, pictureBox.Width / 2, 0, pictureBox.Width / 2, pictureBox.Height);
            g.DrawString("Y", new Font("Arial", 12), Brushes.Black, new Point(pictureBox.Width / 2 + 10, 10));

            pen.Dispose();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            using (BufferedGraphicsContext context = new BufferedGraphicsContext())
            {
                using (BufferedGraphics bufferedGraphics = context.Allocate(e.Graphics, pictureBox.DisplayRectangle))
                {
                    Graphics g = bufferedGraphics.Graphics;

                    DrawConstraints(g);
                    DrawFeasibleRegion(g);
                    DrawAxes(g);

                    bufferedGraphics.Render(e.Graphics);
                }
            }
        }
    }
}
