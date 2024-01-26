using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace matmetmot
{
    public partial class Form1 : Form
    {
        private List<GraphicsPath> paths = new List<GraphicsPath>();
        private List<string> labels = new List<string>();
        private List<Color> colors = new List<Color>();

        private int amountOfRows = 0;
        private int amountOfColumns = 0;

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

        private void button8_Click(object sender, EventArgs e)
        {
            int rows = 0;
            int cols = 0;

            try
            {
                rows = Convert.ToInt32(textBox3.Text);
                cols = Convert.ToInt32(textBox2.Text);

                amountOfRows = rows;
                amountOfColumns = cols;
            }
            catch (Exception)
            {
                MessageBox.Show("НЕКОРРЕКТНЫЙ ВВОД!");
            }

            if (checkInputForStupid(rows, cols))
            {
                foreach (var pan in this.Controls.OfType<Panel>())
                {
                    pan.Visible = false;
                }
                this.Size = new System.Drawing.Size(panel4.Size.Width + 15, panel4.Size.Height + 40);
                panel4.Visible = true;
                this.Text = "ЗАДАНИЕ 3";

                setupForDataGrid(rows, cols);
            }
            else
            {
                MessageBox.Show("НЕКОРРЕКТНЫЙ ВВОД!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var pan in this.Controls.OfType<Panel>())
            {
                pan.Visible = false;
            }
            this.Size = new System.Drawing.Size(panel5.Size.Width + 15, panel5.Size.Height + 40);
            panel5.Visible = true;
            this.Text = "ВВОД";
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

        private bool checkInputForStupid(int valueA, int valueB)
        {
            if (valueA > 0 && valueB > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void setupForDataGrid(int amountOfRows, int amountOfColumns)
        {
            for (int i = 0; i < amountOfColumns; i++)
            {
                dataGridView2.Columns.Add("Column" + i, "");
            }

            dataGridView2.Rows.Add(amountOfRows);
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

        private void button9_Click(object sender, EventArgs e)
        {
            int[] supply = textBox5.Text.Split(' ').Select(Int32.Parse).ToArray();
            int[] demand = textBox4.Text.Split(' ').Select(Int32.Parse).ToArray();
            int[,] cost = new int[dataGridView2.Rows.Count, dataGridView2.Columns.Count];

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                foreach (DataGridViewColumn col in dataGridView2.Columns)
                {
                    cost[row.Index, col.Index] = Convert.ToInt32(dataGridView2.Rows[row.Index].Cells[col.Index].Value);
                }
            }

            int[,] costNew = new int[dataGridView2.Rows.Count - 1, dataGridView2.Columns.Count];

            for (int i = 0; i < costNew.GetLength(0); i++)
            {
                for (int j = 0; j < costNew.GetLength(1); j++)
                {
                    costNew[i, j] = cost[i, j];
                }
            }

            int[,] result = calculateTable(supply, demand, cost);

            for (int i = 0; i < costNew.GetLength(0); i++)
            {
                for (int j = 0; j < costNew.GetLength(1); j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = result[i, j];
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

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

            //AddConstraint(2, 4, 244, Color.Blue, "6x1 + 27x2 >= 1152");
            //AddConstraint(1, 8, 320, Color.Red, "-18x1 - 9x2 >= -1296");
            //AddConstraint(-3, 4, -64, Color.Green, "6x1 - 27x2 >= -1008");
            //AddConstraint(-4, 4, -132, Color.Purple, "-6x1 - 9x2 <= -504");
            //AddConstraint(-4, -20, 492, Color.Yellow, "-6x1 - 9x2 <= -504");
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

        static int[,] calculateTable(int[] _supply, int[] _demand, int[,] _cost)
        {
            int[] supply = _supply;
            int[] demand = _demand;
            int[,] cost = _cost;

            return northWestmethod(supply, demand);
        }

        static int[,] northWestmethod(int[] _supply, int[] _demand)
        {
            int[] supply = _supply;
            int[] demand = _demand;

            int i = 0;
            int j = 0;
            int total = 0;

            int[,] result = new int[(supply.Length), (demand.Length)];

            while (total < supply.Length + supply.Length)
            {
                int s = supply[i];
                int d = demand[j];
                int v = 0;

                if (s < d)
                {
                    v = s;
                }
                else
                {
                    v = d;
                }

                supply[i] -= v;
                demand[j] -= v;

                //Append result in result[]
                result[i, j] = v;

                //Check destination
                if (supply[i] == 0 & i < supply.Length)
                {
                    i++;
                    total++;
                }
                else if (demand[j] == 0 & j < demand.Length)
                {
                    j++;
                    total++;
                }
            }

            return result;
        }

        static int calculatePrice(int[,] costTable, int[,] supplyTable)
        {
            int result = 0;

            for (int i = 0; i < supplyTable.GetLength(0); i++)
            {
                for (int j = 0; j < supplyTable.GetLength(1); j++)
                {
                    result += costTable[i, j] * supplyTable[i, j];
                }
            }

            return result;
        }
    }
}
