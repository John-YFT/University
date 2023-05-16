namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Date1_day = new System.Windows.Forms.TextBox();
            this.Date1_mount = new System.Windows.Forms.TextBox();
            this.Date1_year = new System.Windows.Forms.TextBox();
            this.Date2_day = new System.Windows.Forms.TextBox();
            this.Date2_mount = new System.Windows.Forms.TextBox();
            this.Date2_year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Vis_1 = new System.Windows.Forms.Button();
            this.Vichs_1 = new System.Windows.Forms.Button();
            this.Vicht_1 = new System.Windows.Forms.Button();
            this.Vicht_2 = new System.Windows.Forms.Button();
            this.Vichs_2 = new System.Windows.Forms.Button();
            this.Vis_2 = new System.Windows.Forms.Button();
            this.Naib = new System.Windows.Forms.Button();
            this.Kol_day = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Raz = new System.Windows.Forms.TextBox();
            this.Naim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Date1_day
            // 
            this.Date1_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date1_day.Location = new System.Drawing.Point(193, 18);
            this.Date1_day.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Date1_day.Name = "Date1_day";
            this.Date1_day.Size = new System.Drawing.Size(57, 20);
            this.Date1_day.TabIndex = 1;
            this.Date1_day.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Date1_mount
            // 
            this.Date1_mount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date1_mount.Location = new System.Drawing.Point(259, 18);
            this.Date1_mount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Date1_mount.Name = "Date1_mount";
            this.Date1_mount.Size = new System.Drawing.Size(57, 20);
            this.Date1_mount.TabIndex = 2;
            // 
            // Date1_year
            // 
            this.Date1_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date1_year.Location = new System.Drawing.Point(325, 18);
            this.Date1_year.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Date1_year.Name = "Date1_year";
            this.Date1_year.Size = new System.Drawing.Size(91, 20);
            this.Date1_year.TabIndex = 3;
            // 
            // Date2_day
            // 
            this.Date2_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date2_day.Location = new System.Drawing.Point(193, 276);
            this.Date2_day.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Date2_day.Name = "Date2_day";
            this.Date2_day.Size = new System.Drawing.Size(57, 20);
            this.Date2_day.TabIndex = 7;
            this.Date2_day.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Date2_mount
            // 
            this.Date2_mount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date2_mount.Location = new System.Drawing.Point(259, 276);
            this.Date2_mount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Date2_mount.Name = "Date2_mount";
            this.Date2_mount.Size = new System.Drawing.Size(57, 20);
            this.Date2_mount.TabIndex = 6;
            // 
            // Date2_year
            // 
            this.Date2_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date2_year.Location = new System.Drawing.Point(325, 276);
            this.Date2_year.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Date2_year.Name = "Date2_year";
            this.Date2_year.Size = new System.Drawing.Size(91, 20);
            this.Date2_year.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Первая дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вторая дата";
            // 
            // Vis_1
            // 
            this.Vis_1.BackColor = System.Drawing.Color.Firebrick;
            this.Vis_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vis_1.ForeColor = System.Drawing.Color.White;
            this.Vis_1.Location = new System.Drawing.Point(29, 60);
            this.Vis_1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Vis_1.Name = "Vis_1";
            this.Vis_1.Size = new System.Drawing.Size(605, 54);
            this.Vis_1.TabIndex = 10;
            this.Vis_1.Text = "Определение високосности года";
            this.Vis_1.UseVisualStyleBackColor = false;
            this.Vis_1.Click += new System.EventHandler(this.Vis_1_Click);
            // 
            // Vichs_1
            // 
            this.Vichs_1.BackColor = System.Drawing.Color.Firebrick;
            this.Vichs_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vichs_1.ForeColor = System.Drawing.Color.White;
            this.Vichs_1.Location = new System.Drawing.Point(29, 122);
            this.Vichs_1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Vichs_1.Name = "Vichs_1";
            this.Vichs_1.Size = new System.Drawing.Size(605, 57);
            this.Vichs_1.TabIndex = 11;
            this.Vichs_1.Text = "Вычисление даты через заданное количество дней";
            this.Vichs_1.UseVisualStyleBackColor = false;
            this.Vichs_1.Click += new System.EventHandler(this.Vichs_1_Click);
            // 
            // Vicht_1
            // 
            this.Vicht_1.BackColor = System.Drawing.Color.Firebrick;
            this.Vicht_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vicht_1.ForeColor = System.Drawing.Color.White;
            this.Vicht_1.Location = new System.Drawing.Point(29, 191);
            this.Vicht_1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Vicht_1.Name = "Vicht_1";
            this.Vicht_1.Size = new System.Drawing.Size(605, 54);
            this.Vicht_1.TabIndex = 12;
            this.Vicht_1.Text = "Вычитание заданного количества дней из даты";
            this.Vicht_1.UseVisualStyleBackColor = false;
            this.Vicht_1.Click += new System.EventHandler(this.Vicht_1_Click);
            // 
            // Vicht_2
            // 
            this.Vicht_2.BackColor = System.Drawing.Color.Firebrick;
            this.Vicht_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vicht_2.ForeColor = System.Drawing.Color.White;
            this.Vicht_2.Location = new System.Drawing.Point(29, 453);
            this.Vicht_2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Vicht_2.Name = "Vicht_2";
            this.Vicht_2.Size = new System.Drawing.Size(605, 54);
            this.Vicht_2.TabIndex = 15;
            this.Vicht_2.Text = "Вычитание заданного количества дней из даты";
            this.Vicht_2.UseVisualStyleBackColor = false;
            this.Vicht_2.Click += new System.EventHandler(this.Vicht_2_Click);
            // 
            // Vichs_2
            // 
            this.Vichs_2.BackColor = System.Drawing.Color.Firebrick;
            this.Vichs_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vichs_2.ForeColor = System.Drawing.Color.White;
            this.Vichs_2.Location = new System.Drawing.Point(29, 384);
            this.Vichs_2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Vichs_2.Name = "Vichs_2";
            this.Vichs_2.Size = new System.Drawing.Size(605, 57);
            this.Vichs_2.TabIndex = 14;
            this.Vichs_2.Text = "Вычисление даты через заданное количество дней\r\n";
            this.Vichs_2.UseVisualStyleBackColor = false;
            this.Vichs_2.Click += new System.EventHandler(this.Vichs_2_Click);
            // 
            // Vis_2
            // 
            this.Vis_2.BackColor = System.Drawing.Color.Firebrick;
            this.Vis_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vis_2.ForeColor = System.Drawing.Color.White;
            this.Vis_2.Location = new System.Drawing.Point(29, 322);
            this.Vis_2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Vis_2.Name = "Vis_2";
            this.Vis_2.Size = new System.Drawing.Size(605, 54);
            this.Vis_2.TabIndex = 13;
            this.Vis_2.Text = "Определение високосности года";
            this.Vis_2.UseVisualStyleBackColor = false;
            this.Vis_2.Click += new System.EventHandler(this.Vis_2_Click);
            // 
            // Naib
            // 
            this.Naib.BackColor = System.Drawing.Color.Firebrick;
            this.Naib.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Naib.ForeColor = System.Drawing.Color.White;
            this.Naib.Location = new System.Drawing.Point(731, 60);
            this.Naib.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Naib.Name = "Naib";
            this.Naib.Size = new System.Drawing.Size(299, 118);
            this.Naib.TabIndex = 16;
            this.Naib.Text = "Наибольшая дата";
            this.Naib.UseVisualStyleBackColor = false;
            this.Naib.Click += new System.EventHandler(this.Naib_Click);
            // 
            // Kol_day
            // 
            this.Kol_day.BackColor = System.Drawing.Color.Firebrick;
            this.Kol_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kol_day.ForeColor = System.Drawing.Color.White;
            this.Kol_day.Location = new System.Drawing.Point(731, 384);
            this.Kol_day.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Kol_day.Name = "Kol_day";
            this.Kol_day.Size = new System.Drawing.Size(299, 118);
            this.Kol_day.TabIndex = 18;
            this.Kol_day.Text = "Количества дней между датами";
            this.Kol_day.UseVisualStyleBackColor = false;
            this.Kol_day.Click += new System.EventHandler(this.Kol_day_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(435, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Kол-во дней";
            // 
            // Raz
            // 
            this.Raz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Raz.Location = new System.Drawing.Point(576, 18);
            this.Raz.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Raz.Name = "Raz";
            this.Raz.Size = new System.Drawing.Size(57, 20);
            this.Raz.TabIndex = 20;
            this.Raz.Text = "1";
            // 
            // Naim
            // 
            this.Naim.BackColor = System.Drawing.Color.Firebrick;
            this.Naim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Naim.ForeColor = System.Drawing.Color.White;
            this.Naim.Location = new System.Drawing.Point(731, 226);
            this.Naim.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Naim.Name = "Naim";
            this.Naim.Size = new System.Drawing.Size(299, 118);
            this.Naim.TabIndex = 17;
            this.Naim.Text = "Наименьшая дата";
            this.Naim.UseVisualStyleBackColor = false;
            this.Naim.Click += new System.EventHandler(this.Naim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1047, 519);
            this.Controls.Add(this.Raz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Kol_day);
            this.Controls.Add(this.Naim);
            this.Controls.Add(this.Naib);
            this.Controls.Add(this.Vicht_2);
            this.Controls.Add(this.Vichs_2);
            this.Controls.Add(this.Vis_2);
            this.Controls.Add(this.Vicht_1);
            this.Controls.Add(this.Vichs_1);
            this.Controls.Add(this.Vis_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date2_day);
            this.Controls.Add(this.Date2_mount);
            this.Controls.Add(this.Date2_year);
            this.Controls.Add(this.Date1_year);
            this.Controls.Add(this.Date1_mount);
            this.Controls.Add(this.Date1_day);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Работа с датами";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox Date1_day;
        public System.Windows.Forms.TextBox Date1_mount;
        public System.Windows.Forms.TextBox Date1_year;
        public System.Windows.Forms.TextBox Date2_day;
        public System.Windows.Forms.TextBox Date2_mount;
        public System.Windows.Forms.TextBox Date2_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Vis_1;
        private System.Windows.Forms.Button Vichs_1;
        private System.Windows.Forms.Button Vicht_1;
        private System.Windows.Forms.Button Vicht_2;
        private System.Windows.Forms.Button Vichs_2;
        private System.Windows.Forms.Button Vis_2;
        private System.Windows.Forms.Button Naib;
        private System.Windows.Forms.Button Kol_day;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Raz;
        private System.Windows.Forms.Button Naim;
    }
}

