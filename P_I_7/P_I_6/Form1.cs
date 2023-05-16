using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace P_I_6
{
    public partial class Form : System.Windows.Forms.Form
    {

        public Form()
        {
            InitializeComponent();
        }
        ArrayList al = new ArrayList();
        Date data = new Date();

        private void заданиеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Table.DataSource = null;
            this.Prosm.Clear();
            //Date[] masdate = (Date[])al.ToArray(typeof(Date));
            //Array.Sort(masdate, new Poisk.SortPoYb());
            al.Sort(new Poisk.SortPoYb());
            //for (int i = 0; i < al.Count; i++)
            //{
            //    al.RemoveAt(i);
            //    al.Insert(i, masdate[i]);
            //    this.Prosm.Text += "Дата " + (i + 1) + ": " + al[i] + "\n";
            //}
            бинарныйToolStripMenuItem.Enabled = false;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Table.AllowUserToAddRows = false;
            просмотретьToolStripMenuItem.Enabled = false;
            сохранитьToolStripMenuItem.Enabled = false;
            редактироватьToolStripMenuItem.Enabled = false;
            работаToolStripMenuItem.Enabled = false;
            бинарныйToolStripMenuItem.Enabled = false;
            поискToolStripMenuItem.Enabled = false;
            заданиеToolStripMenuItem1.Enabled = false;
            задание2ToolStripMenuItem.Enabled = false;
            задание3ToolStripMenuItem.Enabled = false;
        }
 
        private void просмотретьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Prosm.Clear();
            for (int i = 0; i < al.Count; i++)
            {
                this.Prosm.Text += "Дата " + (i+1) + ": " + al[i] + "\n";
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            работаToolStripMenuItem.Enabled = true;
            заданиеToolStripMenuItem1.Enabled = true;
            сохранитьToolStripMenuItem.Enabled = false;
            for (int i = 0; i < Table.RowCount; i++)
            {
                data.Year = Convert.ToInt32(this.Table.Rows[i].Cells[2].Value);
                data.Month = Convert.ToInt32(this.Table.Rows[i].Cells[1].Value);
                data.Day = Convert.ToInt32(this.Table.Rows[i].Cells[0].Value);
                al.Add(new Date(data.Year, data.Month, data.Day));
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table.Rows.Clear();
            Table.Columns.Clear();
            Table.DataSource = null;
            this.Prosm.Clear();
            Table.ColumnCount = 3;
            Table.Columns[2].Name = "Year";
            Table.Columns[1].Name = "Month";
            Table.Columns[0].Name = "Day";
            Table.RowCount = 1;
            for (int i = 1; i <= Table.RowCount; i++)
                Table.Rows[i-1].HeaderCell.Value = Convert.ToString(i);
            просмотретьToolStripMenuItem.Enabled = true;
            редактироватьToolStripMenuItem.Enabled = true;
            загрузитьToolStripMenuItem.Enabled = true;
            сохранитьToolStripMenuItem.Enabled = true;

        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table.DataSource = null;
            Table.Rows.Clear();
            Table.Columns.Clear();
            Table.DataSource = al;
            сохранитьToolStripMenuItem.Enabled = false;
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table.DataSource = null;
            int l = 0;
            using (var reader = new StreamReader("C:/Users/Extro/source/repos/P_I_7/P_I_6/1.txt"))
            {
                Table.Rows.Clear();
                Table.Columns.Clear();
                Table.ColumnCount = 3;
                Table.Columns[2].Name = "Year";
                Table.Columns[1].Name = "Month";
                Table.Columns[0].Name = "Day";
                while (!reader.EndOfStream)
                {
                    Table.RowCount += 1;
                    string[] d = ((string)reader.ReadLine()).Split('.');
                    this.Table.Rows[l].Cells[0].Value = d[0];
                    this.Table.Rows[l].Cells[1].Value = d[1];
                    this.Table.Rows[l].Cells[2].Value = d[2];
                    l++;
                }
            }
            for (int i = 1; i <= Table.RowCount; i++)
                Table.Rows[i - 1].HeaderCell.Value = Convert.ToString(i);
            просмотретьToolStripMenuItem.Enabled = true;
            редактироватьToolStripMenuItem.Enabled = true;
            загрузитьToolStripMenuItem.Enabled = true;
            сохранитьToolStripMenuItem.Enabled = true;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сортировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table.DataSource = null;
            this.Prosm.Clear();
            Date[] masdate = (Date[])al.ToArray(typeof(Date));
            Array.Sort(masdate, new Poisk.SortPoVoz());
            for (int i = 0; i < al.Count; i++)
            {
                al.RemoveAt(i);
                al.Insert(i, masdate[i]);
                this.Prosm.Text += "Дата " + (i+1) + ": " + al[i] + "\n";
            }
            бинарныйToolStripMenuItem.Enabled = true;
        }

        private void линейныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Prosm.Clear();
            data.Year = Convert.ToInt32(this.year.Text);
            data.Month = Convert.ToInt32(this.month.Text);
            data.Day = Convert.ToInt32(this.day.Text);
            string l = data.Day + "." + data.Month + "." + data.Year;
            String[] masdate = new String[al.Count];
            for (int i = 0; i < al.Count; i++)
            {
                masdate[i] = al[i].ToString();
            }
            int num_str = Array.IndexOf(masdate, l);
            if (num_str >= 0)
                this.Prosm.Text = "Строка = " + num_str + "\nДата: " + al[num_str];
            else
                this.Prosm.Text = "Данной даты нет в коллекции!";
        }

        private void бинарныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Prosm.Clear();
            data.Year = Convert.ToInt32(this.year.Text);
            data.Month = Convert.ToInt32(this.month.Text);
            data.Day = Convert.ToInt32(this.day.Text);
            string l = data.Day + "." + data.Month + "." + data.Year;
            String[] masdate = new String[al.Count];
            for (int i = 0; i < al.Count; i++)
            {
                masdate[i] = al[i].ToString();
            }
            int num_str = Array.BinarySearch(masdate, l);
            if (num_str >= 0)
                this.Prosm.Text = "Строка = " + num_str + "\nДата: " + al[num_str];
            else
                this.Prosm.Text = "Данной даты нет в коллекции!";
        }

        private void year_TextChanged(object sender, EventArgs e)
        {
            поискToolStripMenuItem.Enabled = true;
            задание2ToolStripMenuItem.Enabled = true;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "Программа создана для работы с датами.\nНа вход поступает база данных с датами, а уже с этой базой данных совершается:\n\tСортировка\n\tПоиск\n\tи т.д.";
            const string caption = "О программе";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void задание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table.DataSource = null;
            this.Prosm.Clear();
            Date[] mas = (Date[])al.ToArray(typeof(Date));
            Array.Sort(mas, new Poisk.SortPoVoz());
            data.Year = Convert.ToInt32(this.year.Text);
            data.Month = Convert.ToInt32(this.month.Text);
            data.Day = Convert.ToInt32(this.day.Text);
            string l = data.Day + "." + data.Month + "." + data.Year;
            String[] masdate = new String[al.Count];
            for (int i = 0; i < al.Count; i++)
            {
                masdate[i] = mas[i].ToString();
            }
            int num_str = Array.IndexOf(masdate, l);
            if (num_str >= 0)
            {
                if (num_str == (al.Count - 1))
                {
                    this.Prosm.Text += "Дата: " + masdate[(num_str) - 1];
                    this.Prosm.Text += "\nДата: " + masdate[(num_str) - 2];
                }
                else if (num_str == 0)
                {
                    this.Prosm.Text += "Дата: " + masdate[(num_str) + 1];
                    this.Prosm.Text += "\nДата: " + masdate[(num_str) + 2];
                }
                else
                {
                    this.Prosm.Text += "Дата: " + masdate[(num_str) - 1];
                    this.Prosm.Text += "\nДата: " + masdate[(num_str) + 1];
                }
            }
            else
                this.Prosm.Text = "Данной даты нет в коллекции!";
        }

        private void задание3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] masdate = new String[al.Count];
            for (int i = 0; i < al.Count; i++)
            {
                masdate[i] = al[i].ToString();
            }
            this.Prosm.Clear();
            switch (Zadiak.Text)
            {
                case "Змееносец":
                    for (int i = 0; i < al.Count; i++)
                    {
                        string[] d = ((string)masdate[i]).Split('.');
                        if (((Convert.ToInt32(d[0]) >= 30) & ((Convert.ToInt32(d[1]) == 11))) | ((Convert.ToInt32(d[0]) <= 17) & ((Convert.ToInt32(d[1]) == 12))))
                        {
                            this.Prosm.Text += "Дата: " + masdate[i] + "\n";
                        }
                    }
                    break;
                case "Лев":
                    for (int i = 0; i < al.Count; i++)
                    {
                        string[] d = ((string)masdate[i]).Split('.');
                        if (((Convert.ToInt32(d[0]) >= 10) & ((Convert.ToInt32(d[1]) == 8))) | ((Convert.ToInt32(d[0]) <= 15) & ((Convert.ToInt32(d[1]) == 9))))
                        {
                            this.Prosm.Text += "Дата: " + masdate[i] + "\n";
                        }
                    }
                    break;
                case "Овен":
                    for (int i = 0; i < al.Count; i++)
                    {
                        string[] d = ((string)masdate[i]).Split('.');
                        if (((Convert.ToInt32(d[0]) >= 19) & ((Convert.ToInt32(d[1]) == 4))) | ((Convert.ToInt32(d[0]) <= 13) & ((Convert.ToInt32(d[1]) == 5))))
                        {
                            this.Prosm.Text += "Дата: " + masdate[i] + "\n";
                        }
                    }
                    break;
                case "Телец":
                    for (int i = 0; i < al.Count; i++)
                    {
                        string[] d = ((string)masdate[i]).Split('.');
                        if (((Convert.ToInt32(d[0]) >= 14) & ((Convert.ToInt32(d[1]) == 5))) | ((Convert.ToInt32(d[0]) <= 19) & ((Convert.ToInt32(d[1]) == 6))))
                        {
                            this.Prosm.Text += "Дата: " + masdate[i] + "\n";
                        }
                    }
                    break;
                case "Близнецы":
                    for (int i = 0; i < al.Count; i++)
                    {
                        string[] d = ((string)masdate[i]).Split('.');
                        if (((Convert.ToInt32(d[0]) >= 20) & ((Convert.ToInt32(d[1]) == 6))) | ((Convert.ToInt32(d[0]) <= 20) & ((Convert.ToInt32(d[1]) == 7))))
                        {
                            this.Prosm.Text += "Дата: " + masdate[i] + "\n";
                        }
                    }
                    break;
                case "Рак":
                    for (int i = 0; i < al.Count; i++)
                    {
                        string[] d = ((string)masdate[i]).Split('.');
                        if (((Convert.ToInt32(d[0]) >= 21) & ((Convert.ToInt32(d[1]) == 7))) | ((Convert.ToInt32(d[0]) <= 9) & ((Convert.ToInt32(d[1]) == 8))))
                        {
                            this.Prosm.Text += "Дата: " + masdate[i] + "\n";
                        }
                    }
                    break;
                case "Дева":
                    for (int i = 0; i < al.Count; i++)
                    {
                        string[] d = ((string)masdate[i]).Split('.');
                        if (((Convert.ToInt32(d[0]) >= 16) & ((Convert.ToInt32(d[1]) == 9))) | ((Convert.ToInt32(d[0]) <= 30) & ((Convert.ToInt32(d[1]) == 10))))
                        {
                            this.Prosm.Text += "Дата: " + masdate[i] + "\n";
                        }
                    }
                    break;
                case "Весы":
                    for (int i = 0; i < al.Count; i++)
                    {
                        string[] d = ((string)masdate[i]).Split('.');
                        if (((Convert.ToInt32(d[0]) >= 31) & ((Convert.ToInt32(d[1]) == 10))) | ((Convert.ToInt32(d[0]) <= 22) & ((Convert.ToInt32(d[1]) == 11))))
                        {
                            this.Prosm.Text += "Дата: " + masdate[i] + "\n";
                        }
                    }
                    break;
                case "Скорпион":
                    for (int i = 0; i < al.Count; i++)
                    {
                        string[] d = ((string)masdate[i]).Split('.');
                        if (((Convert.ToInt32(d[0]) >= 23) & ((Convert.ToInt32(d[1]) == 11))) | ((Convert.ToInt32(d[0]) <= 29) & ((Convert.ToInt32(d[1]) == 11))))
                        {
                            this.Prosm.Text += "Дата: " + masdate[i] + "\n";
                        }
                    }
                    break;
                case "Стрелец":
                    for (int i = 0; i < al.Count; i++)
                    {
                        string[] d = ((string)masdate[i]).Split('.');
                        if (((Convert.ToInt32(d[0]) >= 18) & ((Convert.ToInt32(d[1]) == 12))) | ((Convert.ToInt32(d[0]) <= 18) & ((Convert.ToInt32(d[1]) == 1))))
                        {
                            this.Prosm.Text += "Дата: " + masdate[i] + "\n";
                        }
                    }
                    break;
                case "Козерог":
                    for (int i = 0; i < al.Count; i++)
                    {
                        string[] d = ((string)masdate[i]).Split('.');
                        if (((Convert.ToInt32(d[0]) >= 19) & ((Convert.ToInt32(d[1]) == 1))) | ((Convert.ToInt32(d[0]) <= 15) & ((Convert.ToInt32(d[1]) == 2))))
                        {
                            this.Prosm.Text += "Дата: " + masdate[i] + "\n";
                        }
                    }
                    break;
                case "Водолей":
                    for (int i = 0; i < al.Count; i++)
                    {
                        string[] d = ((string)masdate[i]).Split('.');
                        if (((Convert.ToInt32(d[0]) >= 16) & ((Convert.ToInt32(d[1]) == 2))) | ((Convert.ToInt32(d[0]) <= 11) & ((Convert.ToInt32(d[1]) == 3))))
                        {
                            this.Prosm.Text += "Дата: " + masdate[i] + "\n";
                        }
                    }
                    break;
                case "Рыбы":
                    for (int i = 0; i < al.Count; i++)
                    {
                        string[] d = ((string)masdate[i]).Split('.');
                        if (((Convert.ToInt32(d[0]) >= 12) & ((Convert.ToInt32(d[1]) == 3))) | ((Convert.ToInt32(d[0]) <= 18) & ((Convert.ToInt32(d[1]) == 4))))
                        {
                            this.Prosm.Text += "Дата: " + masdate[i] + "\n";
                        }
                    }
                    break;
                default:
                    this.Prosm.Text += "Данного знака зодиака нет!";
                    break;
            }
        }

        private void Zadiak_TextChanged(object sender, EventArgs e)
        {
            задание3ToolStripMenuItem.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //al.Add(new Date(2003, 11, 2));
            //List<Date> a = new List<Date>();
            //a.Add((Date)al[0]);
            //Prosm.Text = Convert.ToString(a[0].Day);
            al.Add(new Date(2003, 11, 2));
            Date[] d = (Date[])al.ToArray(typeof(Date));
            Prosm.Text = Convert.ToString(d[0].Day);
        }
    }
}