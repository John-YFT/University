namespace P_I_5
{
    partial class form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.Table = new System.Windows.Forms.DataGridView();
            this.Ras = new System.Windows.Forms.Button();
            this.Grapfic = new System.Windows.Forms.Panel();
            this.Rand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            this.Table.BackgroundColor = System.Drawing.Color.Firebrick;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.GridColor = System.Drawing.Color.Firebrick;
            this.Table.Location = new System.Drawing.Point(61, 12);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(343, 70);
            this.Table.TabIndex = 0;
            // 
            // Ras
            // 
            this.Ras.BackColor = System.Drawing.Color.Firebrick;
            this.Ras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ras.Location = new System.Drawing.Point(61, 88);
            this.Ras.Name = "Ras";
            this.Ras.Size = new System.Drawing.Size(157, 37);
            this.Ras.TabIndex = 2;
            this.Ras.Text = "Построить";
            this.Ras.UseVisualStyleBackColor = false;
            this.Ras.Click += new System.EventHandler(this.button1_Click);
            // 
            // Grapfic
            // 
            this.Grapfic.BackColor = System.Drawing.Color.Black;
            this.Grapfic.Location = new System.Drawing.Point(12, 147);
            this.Grapfic.Name = "Grapfic";
            this.Grapfic.Size = new System.Drawing.Size(452, 360);
            this.Grapfic.TabIndex = 3;
            this.Grapfic.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Rand
            // 
            this.Rand.BackColor = System.Drawing.Color.Firebrick;
            this.Rand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rand.Location = new System.Drawing.Point(247, 88);
            this.Rand.Name = "Rand";
            this.Rand.Size = new System.Drawing.Size(157, 37);
            this.Rand.TabIndex = 4;
            this.Rand.Text = "Рандом";
            this.Rand.UseVisualStyleBackColor = false;
            this.Rand.Click += new System.EventHandler(this.Rand_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(479, 519);
            this.Controls.Add(this.Rand);
            this.Controls.Add(this.Grapfic);
            this.Controls.Add(this.Ras);
            this.Controls.Add(this.Table);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form";
            this.Text = "Гистограмма";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button Ras;
        private System.Windows.Forms.Panel Grapfic;
        private System.Windows.Forms.Button Rand;
    }
}

