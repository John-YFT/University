using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_I_10_all
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip manual = new ToolTip();
            manual.SetToolTip(pechat1, "Инструкция: после первого введенного символа запускается секундомер, для остановки секундомера нужно нажать Enter");
            manual.SetToolTip(newDataGridView1, "Инструкция: при установке кол-ва строк и столбцов динамически изменяется таблица");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Время = " + pechat1.time, "Скорость печати:", MessageBoxButtons.OK);
        }

    }
}
