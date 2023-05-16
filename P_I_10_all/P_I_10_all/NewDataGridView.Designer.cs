namespace P_I_10_all
{
    partial class NewDataGridView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.n = new System.Windows.Forms.DomainUpDown();
            this.m = new System.Windows.Forms.DomainUpDown();
            this.Table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(-19, -19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // n
            // 
            this.n.Items.Add("1");
            this.n.Items.Add("2");
            this.n.Items.Add("3");
            this.n.Items.Add("4");
            this.n.Items.Add("5");
            this.n.Items.Add("6");
            this.n.Items.Add("7");
            this.n.Items.Add("8");
            this.n.Items.Add("9");
            this.n.Location = new System.Drawing.Point(3, 3);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(93, 22);
            this.n.TabIndex = 1;
            this.n.Text = "Строка";
            this.n.SelectedItemChanged += new System.EventHandler(this.n_SelectedItemChanged);
            // 
            // m
            // 
            this.m.Items.Add("1");
            this.m.Items.Add("2");
            this.m.Items.Add("3");
            this.m.Items.Add("4");
            this.m.Items.Add("5");
            this.m.Items.Add("6");
            this.m.Items.Add("7");
            this.m.Items.Add("8");
            this.m.Items.Add("9");
            this.m.Location = new System.Drawing.Point(374, 3);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(93, 22);
            this.m.TabIndex = 2;
            this.m.Text = "Столбец";
            this.m.SelectedItemChanged += new System.EventHandler(this.m_SelectedItemChanged);
            // 
            // Table
            // 
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(3, 35);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 51;
            this.Table.RowTemplate.Height = 24;
            this.Table.Size = new System.Drawing.Size(464, 119);
            this.Table.TabIndex = 3;
            // 
            // NewDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Table);
            this.Controls.Add(this.m);
            this.Controls.Add(this.n);
            this.Controls.Add(this.checkBox1);
            this.Name = "NewDataGridView";
            this.Size = new System.Drawing.Size(471, 157);
            this.Load += new System.EventHandler(this.NewDataGridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DomainUpDown n;
        private System.Windows.Forms.DomainUpDown m;
        private System.Windows.Forms.DataGridView Table;
    }
}
