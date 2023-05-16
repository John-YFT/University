namespace P_I_6
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Nyton_function2 = new System.Windows.Forms.Button();
            this.Nyton_function1 = new System.Windows.Forms.Button();
            this.PD_function1 = new System.Windows.Forms.Button();
            this.PD_function2 = new System.Windows.Forms.Button();
            this.PromRez = new System.Windows.Forms.CheckBox();
            this.graphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Eps = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Rez_X = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.graphic)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nyton_function2
            // 
            this.Nyton_function2.BackColor = System.Drawing.Color.DarkRed;
            this.Nyton_function2.ForeColor = System.Drawing.Color.White;
            this.Nyton_function2.Location = new System.Drawing.Point(3, 3);
            this.Nyton_function2.Name = "Nyton_function2";
            this.Nyton_function2.Size = new System.Drawing.Size(252, 125);
            this.Nyton_function2.TabIndex = 14;
            this.Nyton_function2.Text = "Метод Ньютона";
            this.Nyton_function2.UseVisualStyleBackColor = false;
            this.Nyton_function2.Click += new System.EventHandler(this.Nyton_function2_Click);
            // 
            // Nyton_function1
            // 
            this.Nyton_function1.BackColor = System.Drawing.Color.DarkRed;
            this.Nyton_function1.ForeColor = System.Drawing.Color.White;
            this.Nyton_function1.Location = new System.Drawing.Point(3, 3);
            this.Nyton_function1.Name = "Nyton_function1";
            this.Nyton_function1.Size = new System.Drawing.Size(252, 125);
            this.Nyton_function1.TabIndex = 10;
            this.Nyton_function1.Text = "Метод Ньютона";
            this.Nyton_function1.UseVisualStyleBackColor = false;
            this.Nyton_function1.Click += new System.EventHandler(this.Nyton_function1_Click);
            // 
            // PD_function1
            // 
            this.PD_function1.BackColor = System.Drawing.Color.DarkRed;
            this.PD_function1.ForeColor = System.Drawing.Color.White;
            this.PD_function1.Location = new System.Drawing.Point(259, 3);
            this.PD_function1.Name = "PD_function1";
            this.PD_function1.Size = new System.Drawing.Size(252, 125);
            this.PD_function1.TabIndex = 15;
            this.PD_function1.Text = "Метод половинного деления";
            this.PD_function1.UseVisualStyleBackColor = false;
            this.PD_function1.Click += new System.EventHandler(this.PD_function1_Click);
            // 
            // PD_function2
            // 
            this.PD_function2.BackColor = System.Drawing.Color.DarkRed;
            this.PD_function2.ForeColor = System.Drawing.Color.White;
            this.PD_function2.Location = new System.Drawing.Point(259, 3);
            this.PD_function2.Name = "PD_function2";
            this.PD_function2.Size = new System.Drawing.Size(252, 125);
            this.PD_function2.TabIndex = 16;
            this.PD_function2.Text = "Метод половинного деления";
            this.PD_function2.UseVisualStyleBackColor = false;
            this.PD_function2.Click += new System.EventHandler(this.PD_function2_Click);
            // 
            // PromRez
            // 
            this.PromRez.AutoSize = true;
            this.PromRez.BackColor = System.Drawing.Color.Transparent;
            this.PromRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PromRez.ForeColor = System.Drawing.Color.White;
            this.PromRez.Location = new System.Drawing.Point(530, 117);
            this.PromRez.Name = "PromRez";
            this.PromRez.Size = new System.Drawing.Size(317, 54);
            this.PromRez.TabIndex = 17;
            this.PromRez.Text = "Включить \r\nпромежуточный результат";
            this.PromRez.UseVisualStyleBackColor = false;
            // 
            // graphic
            // 
            this.graphic.BackColor = System.Drawing.Color.Transparent;
            this.graphic.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DarkRed;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkRed;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DarkRed;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkRed;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.graphic.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            legend1.ForeColor = System.Drawing.Color.DarkRed;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.graphic.Legends.Add(legend1);
            this.graphic.Location = new System.Drawing.Point(15, 180);
            this.graphic.Name = "graphic";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.MarkerSize = 10;
            series1.Name = "Series1";
            this.graphic.Series.Add(series1);
            this.graphic.Size = new System.Drawing.Size(823, 363);
            this.graphic.TabIndex = 18;
            this.graphic.Text = "chart1";
            // 
            // Eps
            // 
            this.Eps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Eps.Location = new System.Drawing.Point(666, 9);
            this.Eps.Name = "Eps";
            this.Eps.Size = new System.Drawing.Size(181, 26);
            this.Eps.TabIndex = 19;
            this.Eps.TextChanged += new System.EventHandler(this.Eps_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(525, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Точность ->";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(522, 173);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.Nyton_function1);
            this.tabPage1.Controls.Add(this.PD_function1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(514, 131);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "sin(x+1)=2(x+3)^3";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.Nyton_function2);
            this.tabPage2.Controls.Add(this.PD_function2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(514, 131);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "x^3-x^2+4x-1=0";
            // 
            // Rez_X
            // 
            this.Rez_X.BackColor = System.Drawing.Color.Black;
            this.Rez_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rez_X.ForeColor = System.Drawing.Color.White;
            this.Rez_X.Location = new System.Drawing.Point(530, 39);
            this.Rez_X.Name = "Rez_X";
            this.Rez_X.ReadOnly = true;
            this.Rez_X.Size = new System.Drawing.Size(317, 72);
            this.Rez_X.TabIndex = 22;
            this.Rez_X.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::P_I_6.Properties.Resources.fon1;
            this.ClientSize = new System.Drawing.Size(871, 555);
            this.Controls.Add(this.Rez_X);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Eps);
            this.Controls.Add(this.graphic);
            this.Controls.Add(this.PromRez);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Yravneniy";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graphic)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nyton_function2;
        private System.Windows.Forms.Button Nyton_function1;
        private System.Windows.Forms.Button PD_function1;
        private System.Windows.Forms.Button PD_function2;
        public System.Windows.Forms.CheckBox PromRez;
        public System.Windows.Forms.DataVisualization.Charting.Chart graphic;
        private System.Windows.Forms.TextBox Eps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox Rez_X;
    }
}

