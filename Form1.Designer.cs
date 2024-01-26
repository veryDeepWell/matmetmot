namespace matmetmot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox = new PictureBox();
            button4 = new Button();
            panel3 = new Panel();
            label2 = new Label();
            textBox1 = new TextBox();
            button7 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            button5 = new Button();
            panel4 = new Panel();
            dataGridView2 = new DataGridView();
            button6 = new Button();
            panel5 = new Panel();
            button8 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button9 = new Button();
            button10 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(64, 32);
            button1.Name = "button1";
            button1.Size = new Size(130, 40);
            button1.TabIndex = 0;
            button1.Text = "ЗАДАНИЕ 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(64, 79);
            button2.Name = "button2";
            button2.Size = new Size(130, 40);
            button2.TabIndex = 1;
            button2.Text = "ЗАДАНИЕ 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(64, 126);
            button3.Name = "button3";
            button3.Size = new Size(130, 40);
            button3.TabIndex = 2;
            button3.Text = "ЗАДАНИЕ 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 199);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox);
            panel2.Controls.Add(button4);
            panel2.Location = new Point(12, 232);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 500);
            panel2.TabIndex = 4;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(400, 400);
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;
            pictureBox.Paint += pictureBox_Paint;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(434, 3);
            button4.Name = "button4";
            button4.Size = new Size(63, 23);
            button4.TabIndex = 3;
            button4.Text = "НАЗАД";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(button5);
            panel3.Location = new Point(518, 232);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 500);
            panel3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 160);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 9;
            label2.Text = "Время:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // button7
            // 
            button7.Location = new Point(3, 197);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 7;
            button7.Text = "РАЧЕТ";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(3, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(494, 118);
            dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "Пр1";
            Column1.Name = "Column1";
            Column1.Width = 70;
            // 
            // Column2
            // 
            Column2.HeaderText = "Пр2";
            Column2.Name = "Column2";
            Column2.Width = 70;
            // 
            // Column3
            // 
            Column3.HeaderText = "Зт1";
            Column3.Name = "Column3";
            Column3.Width = 70;
            // 
            // Column4
            // 
            Column4.HeaderText = "Зт2";
            Column4.Name = "Column4";
            Column4.Width = 70;
            // 
            // Column5
            // 
            Column5.HeaderText = "Пл";
            Column5.Name = "Column5";
            Column5.Width = 70;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 252);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 5;
            label1.Text = ":)";
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(434, 3);
            button5.Name = "button5";
            button5.Size = new Size(63, 23);
            button5.TabIndex = 4;
            button5.Text = "НАЗАД";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button10);
            panel4.Controls.Add(button9);
            panel4.Controls.Add(dataGridView2);
            panel4.Controls.Add(button6);
            panel4.Location = new Point(1024, 232);
            panel4.Name = "panel4";
            panel4.Size = new Size(500, 500);
            panel4.TabIndex = 5;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 32);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(494, 118);
            dataGridView2.TabIndex = 7;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(434, 3);
            button6.Name = "button6";
            button6.Size = new Size(63, 23);
            button6.TabIndex = 1;
            button6.Text = "НАЗАД";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button8);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(textBox2);
            panel5.Location = new Point(518, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(295, 199);
            panel5.TabIndex = 6;
            // 
            // button8
            // 
            button8.Location = new Point(108, 162);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 5;
            button8.Text = "ВВОД";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(165, 78);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 4;
            label5.Text = "Количество строк";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 78);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 3;
            label4.Text = "Количество столбцов";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 32);
            label3.Name = "label3";
            label3.Size = new Size(219, 15);
            label3.TabIndex = 2;
            label3.Text = "Введите количество строк и столбцов!";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox3.Location = new Point(165, 96);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(127, 23);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox2.Location = new Point(3, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 23);
            textBox2.TabIndex = 0;
            // 
            // button9
            // 
            button9.Location = new Point(3, 168);
            button9.Name = "button9";
            button9.Size = new Size(128, 23);
            button9.TabIndex = 8;
            button9.Text = "РАСЧЕТ";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(3, 197);
            button10.Name = "button10";
            button10.Size = new Size(128, 23);
            button10.TabIndex = 9;
            button10.Text = "ОПТИМИЗАЦИЯ";
            button10.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1705, 849);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button button7;
        private Label label2;
        private TextBox textBox1;
        private PictureBox pictureBox;
        private DataGridView dataGridView2;
        private Panel panel5;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button8;
        private Button button10;
        private Button button9;
    }
}