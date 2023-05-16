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
using static System.Net.Mime.MediaTypeNames;
using System.Security.Policy;
using System.Drawing.Printing;

namespace P_I_5
{
    public partial class form : Form
    {
        static int stolb = 3;
        static int stroc = 2;
        static int kolTreyg = 6;
        Array massZnach = new Array(stroc, stolb);
        public form()
        {
            InitializeComponent();
        }

        private void fon()
        {
            Pen Pen = new Pen(Color.White, 1);
            Graphics g = Graphics.FromHwnd(Grapfic.Handle);
            g.Clear(Color.Black);
            PointF granica1 = new PointF(10.0F, 0.0F);
            PointF granica2 = new PointF(10.0F, 350.0F);
            PointF granica3 = new PointF(440.0F, 350.0F);
            PointF[] Granics = new PointF[] { granica1, granica2, granica3 };
            g.DrawLines(Pen, Granics);
            int y = 0;
            for (int i = 0; i <= kolTreyg; i++)
            {
                PointF tochka = new PointF(5.0F, y);
                PointF tochka_ = new PointF(15.0F, y);
                y += 50;
                PointF[] _tochka_ = new PointF[] { tochka, tochka_ };
                g.DrawLines(Pen, _tochka_);
            }
        }
        private void name()
        {
            Table.ColumnCount = stolb;
            Table.Columns[0].Name = "Ряд 1";
            Table.Columns[1].Name = "Ряд 2";
            Table.Columns[2].Name = "Ряд 3";
            Table.RowCount = stroc;
        }

        private void StyleTable()
        {
            Table.RowsDefaultCellStyle.BackColor = Color.DarkTurquoise;
            Table.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkSeaGreen;
            Table.EnableHeadersVisualStyles = false;
            Table.ColumnHeadersDefaultCellStyle.BackColor = Color.Firebrick;
            Table.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Table.RowHeadersDefaultCellStyle.BackColor = Color.Firebrick;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            name();
            StyleTable();
        }

        private void Error()
        {
            const string message = "Вы ввели неправильное значение для треугольника";
            const string caption = "Ошибка!";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void ErrorPredel()
        {
            const string message = "Вы вышли за пределы графика\n\tМаксимальное значение: 350";
            const string caption = "Ошибка!";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void Grafick()
        {
            SolidBrush redBrush = new SolidBrush(Color.DarkTurquoise);
            Graphics g = Graphics.FromHwnd(Grapfic.Handle);
            int x = 50, numTr = 0;
            for (int j = 0; j < stolb; j++)
            {
                for (int i = 0; i < stroc; i++)
                {
                    PointF tochka1 = new PointF(x, 350.0F);
                    PointF tochka2 = new PointF(x += 20, (350 - massZnach.Mass(i, j)));
                    PointF tochka3 = new PointF(x += 20, 350.0F);
                    PointF[] tr = new PointF[] { tochka1, tochka2, tochka3 };
                    g.FillPolygon(redBrush, tr);
                    numTr++;
                    if (numTr % 2 == 0)
                    {
                        x += 50;
                        redBrush = new SolidBrush(Color.DarkTurquoise);
                    }
                    else
                        redBrush = new SolidBrush(Color.DarkSeaGreen);
                }
            }
        }

        private void zapolnenieRand()
        {
            massZnach.zapRand(1, 350);
            for (int i = 0; i < stroc; i++)
                for (int j = 0; j < stolb; j++)
                {
                    Table.Rows[i].Cells[j].Value = massZnach.Mass(i, j);
                }
        }
        private bool zapolnenie()
        {
            for (int i = 0; i < stroc; i++)
                for (int j = 0; j < stolb; j++)
                {
                    if (Convert.ToString(Table.Rows[i].Cells[j].Value) == "")
                    {
                        Error();
                        return false;
                    }
                    if (Convert.ToInt32(Table.Rows[i].Cells[j].Value) > 350)
                    {
                        ErrorPredel();
                        return false;
                    }
                    massZnach.zapMas(i, j, Convert.ToInt32(Table.Rows[i].Cells[j].Value));
                }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fon();
            if (zapolnenie()) 
                Grafick();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            fon();
        }

        private void Rand_Click(object sender, EventArgs e)
        {
            
            fon();
            zapolnenieRand();
            Grafick();
        }
    }
}
