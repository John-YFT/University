namespace P_I_10_all
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.newDataGridView1 = new P_I_10_all.NewDataGridView();
            this.pechat1 = new P_I_10_all.Pechat();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(12, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Посмотреть время";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newDataGridView1
            // 
            this.newDataGridView1.BackColor = System.Drawing.Color.Transparent;
            this.newDataGridView1.BackColorM = System.Drawing.Color.LightBlue;
            this.newDataGridView1.BackColorN = System.Drawing.Color.LightBlue;
            this.newDataGridView1.BackColorTable = System.Drawing.Color.Lavender;
            this.newDataGridView1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.newDataGridView1.CellsColor = System.Drawing.Color.LightBlue;
            this.newDataGridView1.ColumnsHeaderColor = System.Drawing.Color.CornflowerBlue;
            this.newDataGridView1.Location = new System.Drawing.Point(374, 12);
            this.newDataGridView1.Name = "newDataGridView1";
            this.newDataGridView1.RowsHeaderColor = System.Drawing.Color.CornflowerBlue;
            this.newDataGridView1.SetkaColor = System.Drawing.Color.DarkBlue;
            this.newDataGridView1.Size = new System.Drawing.Size(471, 157);
            this.newDataGridView1.TabIndex = 4;
            // 
            // pechat1
            // 
            this.pechat1.BackColor = System.Drawing.Color.Lavender;
            this.pechat1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.pechat1.ColorPrew = System.Drawing.Color.DodgerBlue;
            this.pechat1.Font = new System.Drawing.Font("Arial", 11.25F);
            this.pechat1.FontText = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.pechat1.ForeColor = System.Drawing.Color.Black;
            this.pechat1.Location = new System.Drawing.Point(12, 12);
            this.pechat1.Name = "pechat1";
            this.pechat1.Size = new System.Drawing.Size(300, 40);
            this.pechat1.TabIndex = 5;
            this.pechat1.Text = "pechat1";
            this.pechat1.time = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 190);
            this.Controls.Add(this.pechat1);
            this.Controls.Add(this.newDataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ЭУ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private NewDataGridView newDataGridView1;
        private Pechat pechat1;
    }
}

