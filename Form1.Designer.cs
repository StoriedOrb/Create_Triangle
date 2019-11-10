namespace Create_triangle
{
    partial class Create
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.X1label = new System.Windows.Forms.Label();
            this.X2label = new System.Windows.Forms.Label();
            this.X3label = new System.Windows.Forms.Label();
            this.Y1label = new System.Windows.Forms.Label();
            this.Y2label = new System.Windows.Forms.Label();
            this.Y3label = new System.Windows.Forms.Label();
            this.Coordinate = new System.Windows.Forms.Label();
            this.Y2TextBox = new System.Windows.Forms.TextBox();
            this.Y1TextBox = new System.Windows.Forms.TextBox();
            this.X3TextBox = new System.Windows.Forms.TextBox();
            this.X2TextBox = new System.Windows.Forms.TextBox();
            this.X1TextBox = new System.Windows.Forms.TextBox();
            this.TriangleBox = new System.Windows.Forms.TextBox();
            this.Y3TextBox = new System.Windows.Forms.TextBox();
            this.Random = new System.Windows.Forms.Button();
            this.Calculation = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // X1label
            // 
            this.X1label.AutoSize = true;
            this.X1label.Location = new System.Drawing.Point(12, 59);
            this.X1label.Name = "X1label";
            this.X1label.Size = new System.Drawing.Size(20, 13);
            this.X1label.TabIndex = 0;
            this.X1label.Text = "X1";
            // 
            // X2label
            // 
            this.X2label.AutoSize = true;
            this.X2label.Location = new System.Drawing.Point(12, 101);
            this.X2label.Name = "X2label";
            this.X2label.Size = new System.Drawing.Size(20, 13);
            this.X2label.TabIndex = 1;
            this.X2label.Text = "X2";
            // 
            // X3label
            // 
            this.X3label.AutoSize = true;
            this.X3label.Location = new System.Drawing.Point(12, 141);
            this.X3label.Name = "X3label";
            this.X3label.Size = new System.Drawing.Size(20, 13);
            this.X3label.TabIndex = 2;
            this.X3label.Text = "X3";
            // 
            // Y1label
            // 
            this.Y1label.AutoSize = true;
            this.Y1label.Location = new System.Drawing.Point(244, 59);
            this.Y1label.Name = "Y1label";
            this.Y1label.Size = new System.Drawing.Size(20, 13);
            this.Y1label.TabIndex = 3;
            this.Y1label.Text = "Y1";
            // 
            // Y2label
            // 
            this.Y2label.AutoSize = true;
            this.Y2label.Location = new System.Drawing.Point(244, 101);
            this.Y2label.Name = "Y2label";
            this.Y2label.Size = new System.Drawing.Size(20, 13);
            this.Y2label.TabIndex = 4;
            this.Y2label.Text = "Y2";
            // 
            // Y3label
            // 
            this.Y3label.AutoSize = true;
            this.Y3label.Location = new System.Drawing.Point(244, 141);
            this.Y3label.Name = "Y3label";
            this.Y3label.Size = new System.Drawing.Size(20, 13);
            this.Y3label.TabIndex = 5;
            this.Y3label.Text = "Y3";
            // 
            // Coordinate
            // 
            this.Coordinate.AutoSize = true;
            this.Coordinate.Location = new System.Drawing.Point(12, 20);
            this.Coordinate.Name = "Coordinate";
            this.Coordinate.Size = new System.Drawing.Size(110, 13);
            this.Coordinate.TabIndex = 6;
            this.Coordinate.Text = "Координаты вершин";
            // 
            // Y2TextBox
            // 
            this.Y2TextBox.Location = new System.Drawing.Point(314, 98);
            this.Y2TextBox.Name = "Y2TextBox";
            this.Y2TextBox.Size = new System.Drawing.Size(83, 20);
            this.Y2TextBox.TabIndex = 7;
            // 
            // Y1TextBox
            // 
            this.Y1TextBox.Location = new System.Drawing.Point(314, 56);
            this.Y1TextBox.Name = "Y1TextBox";
            this.Y1TextBox.Size = new System.Drawing.Size(83, 20);
            this.Y1TextBox.TabIndex = 8;
            // 
            // X3TextBox
            // 
            this.X3TextBox.Location = new System.Drawing.Point(65, 138);
            this.X3TextBox.Name = "X3TextBox";
            this.X3TextBox.Size = new System.Drawing.Size(83, 20);
            this.X3TextBox.TabIndex = 9;
            // 
            // X2TextBox
            // 
            this.X2TextBox.Location = new System.Drawing.Point(65, 98);
            this.X2TextBox.Name = "X2TextBox";
            this.X2TextBox.Size = new System.Drawing.Size(83, 20);
            this.X2TextBox.TabIndex = 10;
            // 
            // X1TextBox
            // 
            this.X1TextBox.Location = new System.Drawing.Point(65, 55);
            this.X1TextBox.Name = "X1TextBox";
            this.X1TextBox.Size = new System.Drawing.Size(83, 20);
            this.X1TextBox.TabIndex = 11;
            // 
            // TriangleBox
            // 
            this.TriangleBox.Location = new System.Drawing.Point(15, 185);
            this.TriangleBox.Multiline = true;
            this.TriangleBox.Name = "TriangleBox";
            this.TriangleBox.ReadOnly = true;
            this.TriangleBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TriangleBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TriangleBox.Size = new System.Drawing.Size(382, 264);
            this.TriangleBox.TabIndex = 12;
            // 
            // Y3TextBox
            // 
            this.Y3TextBox.Location = new System.Drawing.Point(314, 138);
            this.Y3TextBox.Name = "Y3TextBox";
            this.Y3TextBox.Size = new System.Drawing.Size(83, 20);
            this.Y3TextBox.TabIndex = 13;
            // 
            // Random
            // 
            this.Random.BackColor = System.Drawing.Color.YellowGreen;
            this.Random.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Random.Location = new System.Drawing.Point(15, 455);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(108, 34);
            this.Random.TabIndex = 14;
            this.Random.Text = "Задать случайно";
            this.Random.UseVisualStyleBackColor = false;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // Calculation
            // 
            this.Calculation.BackColor = System.Drawing.Color.YellowGreen;
            this.Calculation.Location = new System.Drawing.Point(15, 495);
            this.Calculation.Name = "Calculation";
            this.Calculation.Size = new System.Drawing.Size(108, 34);
            this.Calculation.TabIndex = 15;
            this.Calculation.Text = "Рассчитать";
            this.Calculation.UseVisualStyleBackColor = false;
            this.Calculation.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // Clean
            // 
            this.Clean.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Clean.Location = new System.Drawing.Point(289, 455);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(108, 34);
            this.Clean.TabIndex = 16;
            this.Clean.Text = "Очистить";
            this.Clean.UseVisualStyleBackColor = false;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Exit.Location = new System.Drawing.Point(289, 495);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(108, 34);
            this.Exit.TabIndex = 17;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(415, 535);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.Calculation);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.Y3TextBox);
            this.Controls.Add(this.TriangleBox);
            this.Controls.Add(this.X1TextBox);
            this.Controls.Add(this.X2TextBox);
            this.Controls.Add(this.X3TextBox);
            this.Controls.Add(this.Y1TextBox);
            this.Controls.Add(this.Y2TextBox);
            this.Controls.Add(this.Coordinate);
            this.Controls.Add(this.Y3label);
            this.Controls.Add(this.Y2label);
            this.Controls.Add(this.Y1label);
            this.Controls.Add(this.X3label);
            this.Controls.Add(this.X2label);
            this.Controls.Add(this.X1label);
            this.Name = "Create";
            this.Text = "Построение треугольника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label X1label;
        private System.Windows.Forms.Label X2label;
        private System.Windows.Forms.Label X3label;
        private System.Windows.Forms.Label Y1label;
        private System.Windows.Forms.Label Y2label;
        private System.Windows.Forms.Label Y3label;
        private System.Windows.Forms.Label Coordinate;
        private System.Windows.Forms.TextBox Y2TextBox;
        private System.Windows.Forms.TextBox Y1TextBox;
        private System.Windows.Forms.TextBox X3TextBox;
        private System.Windows.Forms.TextBox X2TextBox;
        private System.Windows.Forms.TextBox X1TextBox;
        private System.Windows.Forms.TextBox TriangleBox;
        private System.Windows.Forms.TextBox Y3TextBox;
        private System.Windows.Forms.Button Random;
        private System.Windows.Forms.Button Calculation;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.Button Exit;
    }
}

