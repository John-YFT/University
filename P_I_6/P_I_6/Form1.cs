using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace P_I_6
{
    public partial class Form1 : Form
    {
        ZnachenieNelineynogoYrovneniy yr = new ZnachenieNelineynogoYrovneniy();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            yr.Notification += Prom_Rez;
            Help();
            Nyton_function1.FlatStyle = FlatStyle.Flat;
            Nyton_function1.FlatAppearance.BorderSize = 0;
            Nyton_function2.FlatStyle = FlatStyle.Flat;
            Nyton_function2.FlatAppearance.BorderSize = 0;
            PD_function1.FlatStyle = FlatStyle.Flat;
            PD_function1.FlatAppearance.BorderSize = 0;
            PD_function2.FlatStyle = FlatStyle.Flat;
            PD_function2.FlatAppearance.BorderSize = 0;
            Nyton_function1.Enabled = false;
            Nyton_function2.Enabled = false;
            PD_function1.Enabled = false;
            PD_function2.Enabled = false;
            tabControl1.Enabled = false;
        }

        private void Help()
        {
            Nyton_function2.HelpRequested += new System.Windows.Forms.HelpEventHandler(Form1_HelpRequested);
            Nyton_function1.HelpRequested += new System.Windows.Forms.HelpEventHandler(Form1_HelpRequested);
            PD_function1.HelpRequested += new System.Windows.Forms.HelpEventHandler(Form1_HelpRequested);
            PD_function2.HelpRequested += new System.Windows.Forms.HelpEventHandler(Form1_HelpRequested);
            Eps.HelpRequested += new System.Windows.Forms.HelpEventHandler(Form1_HelpRequested);
            this.Eps.Tag = "Точность решения(E)";
            this.Nyton_function2.Tag = "Решение уравнения методом Ньютона";
            this.Nyton_function1.Tag = "Решение уравнения методом Ньютона";
            this.PD_function1.Tag = "Решение уравнения методом половинного деления";
            this.PD_function2.Tag = "Решение уравнения методом половинного деления";
        }

        private void Postroenie_graphic(ZnachenieNelineynogoYrovneniy.del f, string name_function)
        {
            graphic.Series[0].Name = name_function;
            graphic.Series[0].Points.Clear();
            for (double i = -5; i <= 5; i += 1)
            {
                graphic.Series[0].Points.AddXY(i, f(i));
            }
        }

        private void Prom_Rez(string Str)
        {
            MessageBox.Show(Str, "Информация", MessageBoxButtons.OK);
        }

        private bool proverka()
        {
            Rez_X.Clear();
            bool flag = true;
            string eps = "";
            foreach (char simvol in Eps.Text)
            {
                if (simvol == '.')
                {
                    eps += ',';
                }
                else
                {
                    eps += simvol;
                }
            }
            Eps.Text = eps;
            foreach (char simvol in Eps.Text)
                if ((!char.IsDigit(simvol)) & (simvol != ','))
                {
                    flag = false;
                }

            if (flag == true)
            {
                try
                {
                    yr.eps = Convert.ToDouble(Eps.Text);
                }
                catch (ArgumentOutOfRangeException x)
                {
                    Prom_Rez(x.ToString());
                }
                catch (Exception ex)
                {
                    Prom_Rez(ex.ToString());
                    flag = false;
                }
            }
            else
            {
                yr.error();
            }

            return flag;
        }

        private void Nyton_function1_Click(object sender, EventArgs e)
        {
            if (proverka())
            {
                Postroenie_graphic(yr.Function_1, "sin(x+1)=2(x+3)^3");
                Rez_X.Text = "sin(x + 1) = 2(x + 3) ^ 3 = " + Convert.ToString(yr.MetodNytona(yr.Function_1, yr.ProizvodnayFunction_1, PromRez.Checked));
            }
            else
                graphic.Series[0].Points.Clear();
        }

        private void Nyton_function2_Click(object sender, EventArgs e)
        {
            if (proverka())
            {
                Postroenie_graphic(yr.Function_2, "x^3-x^2+4x-1=0");
                Rez_X.Text = "x^3 - x^2 + 4x - 1 = 0 = " + Convert.ToString(yr.MetodNytona(yr.Function_2, yr.ProizvodnayFunction_2, PromRez.Checked));
            }
            else
                graphic.Series[0].Points.Clear();
        }

        private void PD_function1_Click(object sender, EventArgs e)
        {
            if (proverka())
            {
                Postroenie_graphic(yr.Function_1, "sin(x+1)=2(x+3)^3");
                Rez_X.Text = "sin(x + 1) = 2(x + 3) ^ 3 = " + Convert.ToString(yr.MetodPolovinnogoDeleniy(yr.Function_1, PromRez.Checked));
            }
            else
                graphic.Series[0].Points.Clear();
        }

        private void PD_function2_Click(object sender, EventArgs e)
        {
            if (proverka())
            {
                Postroenie_graphic(yr.Function_2, "x^3-x^2+4x-1=0");
                Rez_X.Text = "x^3 - x^2 + 4x - 1 = 0 = " + Convert.ToString(yr.MetodPolovinnogoDeleniy(yr.Function_2, PromRez.Checked));
            }
            else
                graphic.Series[0].Points.Clear();
        }

        private void Form1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Control requestingControl = (Control)sender;
            Prom_Rez((string)requestingControl.Tag);
            hlpevent.Handled = true;
        }

        private void Eps_TextChanged(object sender, EventArgs e)
        {
            Nyton_function1.Enabled = true;
            Nyton_function2.Enabled = true;
            PD_function1.Enabled = true;
            PD_function2.Enabled = true;
            tabControl1.Enabled = true;
        }
    }
}