using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            const string message = "Учитывайте что:\n\nГод: \n\tдолжен быть больше 0\nМесяц: \n\tменьше 12 \n\tбольше 0\nДень:\n\t учитывайте кол-во дней в определенном месяце \n\tбольше 0";
            const string caption = "Предупреждение!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);

            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    Button btn = control as Button;
                    btn.Enabled = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if ((control.Name == "Vis_1") | (control.Name == "Vichs_1") | (control.Name == "Vicht_1"))
                {
                    Button btn = control as Button;
                    btn.Enabled = true;
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if ((control.Name == "Vis_2")| (control.Name == "Vichs_2") | (control.Name == "Vicht_2")| (control.Name == "Naib") | (control.Name == "Naim") | (control.Name == "Kol_day"))
                {
                    Button btn = control as Button;
                    btn.Enabled = true;
                }
            }
        }


        private void Vis_1_Click(object sender, EventArgs e)
        {
            Date data1 = new Date(Convert.ToInt32(this.Date1_year.Text), Convert.ToInt32(this.Date1_mount.Text), Convert.ToInt32(this.Date1_day.Text));
            Form2 fm = new Form2();
            if (data1.VisYear(data1))
                fm.Vis_1.Text = "Високостный!";
            else
                fm.Vis_1.Text = "Не високостный";
            fm.ShowDialog();
            
        }

        private void Vichs_1_Click(object sender, EventArgs e)
        {
            Date data1 = new Date(Convert.ToInt32(this.Date1_year.Text), Convert.ToInt32(this.Date1_mount.Text), Convert.ToInt32(this.Date1_day.Text));
            Date data0 = new Date();
            Form2 fm = new Form2();
            data0 = data1.VichDate(data1, Convert.ToInt32(Raz.Text));
            fm.Vichs_1_day.Text = Convert.ToString(data0.Day);
            fm.Vichs_1_mount.Text = Convert.ToString(data0.Month);
            fm.Vichs_1_year.Text = Convert.ToString(data0.Year);
            fm.ShowDialog();
        }

        private void Vicht_1_Click(object sender, EventArgs e)
        {
            Date data1 = new Date(Convert.ToInt32(this.Date1_year.Text), Convert.ToInt32(this.Date1_mount.Text), Convert.ToInt32(this.Date1_day.Text));
            Date data0 = new Date();
            Form2 fm = new Form2();
            data0 = data1 - Convert.ToInt32(Raz.Text);
            fm.Vicht_1_day.Text = Convert.ToString(data0.Day);
            fm.Vicht_1_mount.Text = Convert.ToString(data0.Month);
            fm.Vicht_1_year.Text = Convert.ToString(data0.Year);
            fm.ShowDialog();
        }

        private void Vis_2_Click(object sender, EventArgs e)
        {
            Date data2 = new Date(Convert.ToInt32(this.Date2_year.Text), Convert.ToInt32(this.Date2_mount.Text), Convert.ToInt32(this.Date2_day.Text));
            Form2 fm = new Form2();
            if (data2.VisYear(data2))
                fm.Vis_2.Text = "Високостный";
            else
                fm.Vis_2.Text = "Не високостный";
            fm.ShowDialog();
        }

        private void Vichs_2_Click(object sender, EventArgs e)
        {
            Date data2 = new Date(Convert.ToInt32(this.Date2_year.Text), Convert.ToInt32(this.Date2_mount.Text), Convert.ToInt32(this.Date2_day.Text));
            Date data0 = new Date();
            Form2 fm = new Form2();
            data0 = data2.VichDate(data2, Convert.ToInt32(Raz.Text));
            fm.Vichs_2_day.Text = Convert.ToString(data0.Day);
            fm.Vichs_2_mount.Text = Convert.ToString(data0.Month);
            fm.Vichs_2_year.Text = Convert.ToString(data0.Year);
            fm.ShowDialog();
        }

        private void Vicht_2_Click(object sender, EventArgs e)
        {
            Date data2 = new Date(Convert.ToInt32(this.Date2_year.Text), Convert.ToInt32(this.Date2_mount.Text), Convert.ToInt32(this.Date2_day.Text));
            Date data0 = new Date();
            Form2 fm = new Form2();
            data0 = data2 - Convert.ToInt32(Raz.Text);
            fm.Vicht_2_day.Text = Convert.ToString(data0.Day);
            fm.Vicht_2_mount.Text = Convert.ToString(data0.Month);
            fm.Vicht_2_year.Text = Convert.ToString(data0.Year);
            fm.ShowDialog();
        }

        private void Naib_Click(object sender, EventArgs e)
        {

            Date data1 = new Date(Convert.ToInt32(this.Date1_year.Text), Convert.ToInt32(this.Date1_mount.Text), Convert.ToInt32(this.Date1_day.Text));
            Date data2 = new Date(Convert.ToInt32(this.Date2_year.Text), Convert.ToInt32(this.Date2_mount.Text), Convert.ToInt32(this.Date2_day.Text));
            Form2 fm = new Form2();
            if (data1 > data2)
            {
                fm.Naib_day.Text = Convert.ToString(data1.Day);
                fm.Naib_mount.Text = Convert.ToString(data1.Month);
                fm.Naib_year.Text = Convert.ToString(data1.Year);
            }
            else
            {
                fm.Naib_day.Text = Convert.ToString(data2.Day);
                fm.Naib_mount.Text = Convert.ToString(data2.Month);
                fm.Naib_year.Text = Convert.ToString(data2.Year);
            }
            fm.ShowDialog();
        }

        private void Naim_Click(object sender, EventArgs e)
        {
            Date data1 = new Date(Convert.ToInt32(this.Date1_year.Text), Convert.ToInt32(this.Date1_mount.Text), Convert.ToInt32(this.Date1_day.Text));
            Date data2 = new Date(Convert.ToInt32(this.Date2_year.Text), Convert.ToInt32(this.Date2_mount.Text), Convert.ToInt32(this.Date2_day.Text));
            Form2 fm = new Form2();
            if (data1 < data2)
            {
                fm.Naim_day.Text = Convert.ToString(data1.Day);
                fm.Naim_mount.Text = Convert.ToString(data1.Month);
                fm.Naim_year.Text = Convert.ToString(data1.Year);
            }
            else
            {
                fm.Naim_day.Text = Convert.ToString(data2.Day);
                fm.Naim_mount.Text = Convert.ToString(data2.Month);
                fm.Naim_year.Text = Convert.ToString(data2.Year);
            }
            fm.ShowDialog();
        }

        private void Kol_day_Click(object sender, EventArgs e)
        {
            Date data1 = new Date(Convert.ToInt32(this.Date1_year.Text), Convert.ToInt32(this.Date1_mount.Text), Convert.ToInt32(this.Date1_day.Text));
            Date data2 = new Date(Convert.ToInt32(this.Date2_year.Text), Convert.ToInt32(this.Date2_mount.Text), Convert.ToInt32(this.Date2_day.Text));
            Form2 fm = new Form2();
            fm.Kol_day.Text = Convert.ToString(data1.PromDate(data1, data2));
            fm.ShowDialog();
        }
    }
}

