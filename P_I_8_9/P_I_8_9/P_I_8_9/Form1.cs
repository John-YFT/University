using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P_I_8_9
{
    public partial class Form1 : Form
    {
        BookMetod classbook = new BookMetod();
        List<BookCreate> book = new List<BookCreate>();
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            ContextMenuStrip = contextMenuStrip1;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                button1.PerformClick();
            }
            if (e.KeyCode == Keys.R && e.Control)
            {
                button14.PerformClick();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_DragDrop);
            toolStripButton2.Enabled = false;
            поискToolStripMenuItem.Enabled = false;
            Sort.Enabled = false;
            toolStripSplitButton1.Enabled = false;
            методToolStripMenuItem.Enabled = false;
            суммаСтраницВКнигахToolStripMenuItem.Enabled = false;
            суммаСтраницВКнигахToolStripMenuItem1.Enabled = false;
            CпрошломеждунаписаниемдвухкнигToolStripMenuItem1.Enabled = false;
            промежутокМеждуНаписаниемДвухКнигToolStripMenuItem.Enabled = false;
            manual.SetToolTip(button1, "Горячая клавиша Conrol+S");
            manual.SetToolTip(button14, "Горячая клавиша Conrol+R");
            сохранениеXMLToolStripMenuItem.Enabled = false;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Firebrick;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.Firebrick;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            сохранениеXMLToolStripMenuItem.Enabled = true;
            сохранениеXMLToolStripMenuItem1.Enabled = true;
            textBox12.Enabled = true;
            textBox2.Enabled = true;
            toolStripButton2.Enabled = false;
            поискToolStripMenuItem.Enabled = false;
            Sort.Enabled = true;
            сортировкаToolStripMenuItem.Enabled = true;
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            string Autor = "";
            if (textBox12.Text == "")
            {
                OneAutorBook oneAutorBook = new OneAutorBook();
                oneAutorBook.AutorCreate(textBox2.Text);
                Autor = oneAutorBook.Autors;
            }
            else
            if ((Convert.ToInt32(textBox12.Text) > 1))
            {
                OverAutorBook overAutorBook = new OverAutorBook();
                overAutorBook.AutorCreate(textBox12.Text);
                Autor = overAutorBook.Autors;
            }
            else 
            if ((Convert.ToInt32(textBox12.Text) <= 1))
            {
                OneAutorBook oneAutorBook = new OneAutorBook();
                oneAutorBook.AutorCreate(textBox2.Text);
                Autor = oneAutorBook.Autors;
            }
            if ((textBox1.Text == "") | (Autor == "") | (textBox3.Text == "") | (textBox4.Text == "") | (textBox13.Text == "") | (textBox5.Text == ""))
            {
                throw new InvalidOperationException("Поля должны быть заполнены");
            }
            book.Add(new BookCreate(textBox1.Text, Autor, textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox13.Text), textBox5.Text));
            for (int i = 0; i < book.Count; i++)
            {
                comboBox1.Items.Add(book[i].BookName);
                comboBox2.Items.Add(book[i].BookName);

            }
            treeView1.Nodes.Clear();
            treeView1.BeginUpdate();
            for (int i = 0; i < book.Count; i++)
            {
                treeView1.Nodes.Add(Convert.ToString(book[i].BookName));
                treeView1.Nodes[i].Nodes.Add("Автор: " + Convert.ToString(book[i].Autor));
                treeView1.Nodes[i].Nodes.Add("Переплет: " + Convert.ToString(book[i].Pereplet));
                treeView1.Nodes[i].Nodes.Add("Год выпуска: " + Convert.ToString(book[i].GodVipyska));
                treeView1.Nodes[i].Nodes.Add("Кол-во страниц: " + Convert.ToString(book[i].KolvoStranic));
                treeView1.Nodes[i].Nodes.Add("Краткое содержание: " + Convert.ToString(book[i].KratkoeSoderjanie));
            }
            treeView1.EndUpdate();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox12.Clear();
            textBox13.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            for (int i = 0; i < book.Count; i++)
            {
                richTextBox1.Text += book[i].ToString();
            }
        }



       
        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            foreach (char simvol in textBox12.Text)
                if ((!char.IsDigit(simvol)))
                {
                    throw new InvalidOperationException("Поле должно быть типом int");
                }
            textBox2.Enabled = false;
        }



        private void button14_Click(object sender, EventArgs e)
        {
            сохранениеXMLToolStripMenuItem.Enabled = true;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = book;
        }

        private void treeView1_ItemDrag(object sender, System.Windows.Forms.ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void treeView1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void treeView_DragDrop(object sender, DragEventArgs e)
        {
            Point targetPoint = treeView1.PointToClient(new Point(e.X, e.Y));
            TreeNode targetNode = treeView1.GetNodeAt(targetPoint);
            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
            if (!draggedNode.Equals(targetNode) && targetNode != null)
            {
                draggedNode.Remove();
                targetNode.Nodes.Add(draggedNode);
                targetNode.Expand();
            }
            else
                draggedNode.Remove();
        }

        public void treewiew()
        {
            treeView1.Nodes.Clear();
            treeView1.BeginUpdate();
            for (int i = 0; i < book.Count; i++)
            {
                treeView1.Nodes.Add(Convert.ToString(book[i].BookName));
                treeView1.Nodes[i].Nodes.Add("Автор: " + Convert.ToString(book[i].Autor));
                treeView1.Nodes[i].Nodes.Add("Переплет: " + Convert.ToString(book[i].Pereplet));
                treeView1.Nodes[i].Nodes.Add("Год выпуска: " + Convert.ToString(book[i].GodVipyska));
                treeView1.Nodes[i].Nodes.Add("Кол-во страниц: " + Convert.ToString(book[i].KolvoStranic));
                treeView1.Nodes[i].Nodes.Add("Краткое содержание: " + Convert.ToString(book[i].KratkoeSoderjanie));
            }
            treeView1.EndUpdate();
        }

        private void сохранениеXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<BookCreate>));
            using (FileStream s = new FileStream("Book.xml", FileMode.OpenOrCreate))
                xs.Serialize(s, book);
        }

        private void считываниеXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Sort.Enabled = true;
            сортировкаToolStripMenuItem.Enabled = true;
            XmlSerializer xs = new XmlSerializer(typeof(List<BookCreate>));
            using (FileStream s = new FileStream("Book.xml", FileMode.OpenOrCreate))
                book = (List<BookCreate>)xs.Deserialize(s);
            treewiew();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            for (int i = 0; i < book.Count; i++)
            {
                comboBox1.Items.Add(book[i].BookName);
                comboBox2.Items.Add(book[i].BookName);

            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox12.Clear();
            textBox13.Clear();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string Autor = "";
            if (textBox12.Text == "")
            {
                OneAutorBook oneAutorBook = new OneAutorBook();
                oneAutorBook.AutorCreate(textBox2.Text);
                Autor = oneAutorBook.Autors;
            }
            else
            if ((Convert.ToInt32(textBox12.Text) > 1))
            {
                OverAutorBook overAutorBook = new OverAutorBook();
                overAutorBook.AutorCreate(textBox12.Text);
                Autor = overAutorBook.Autors;
            }
            else
            if ((Convert.ToInt32(textBox12.Text) <= 1))
            {
                OneAutorBook oneAutorBook = new OneAutorBook();
                oneAutorBook.AutorCreate(textBox2.Text);
                Autor = oneAutorBook.Autors;
            }
            if ((textBox1.Text == "") | (Autor == "") | (textBox3.Text == "") | (textBox4.Text == "") | (textBox13.Text == "") | (textBox5.Text == ""))
                {
                    throw new InvalidOperationException("Поля должны быть заполнены");
                }
            int num_str = classbook.Poisk(textBox1.Text, Autor, textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox13.Text), textBox5.Text, book);
            if (num_str >= 0)
                this.richTextBox1.Text = book[num_str].ToString();
            else
                this.richTextBox1.Text = "Данной книги нет!";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox12.Clear();
            textBox13.Clear();
        }

        private void названиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Namebook> books = new List<Namebook>();
            for (int i = 0; i < book.Count; i++)
            {
                books.Add((Namebook)book[i]);
            }
            books.Sort();
            book.Clear();
            for (int i = 0; i < books.Count; i++)
            {
                book.Add((BookCreate)books[i]);
            }
            treewiew();
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Autorbook> books = new List<Autorbook>();
            for (int i = 0; i < book.Count; i++)
            {
                books.Add((Autorbook)book[i]);
            }
            books.Sort();
            book.Clear();
            for (int i = 0; i < books.Count; i++)
            {
                book.Add((BookCreate)books[i]);
            }
            treewiew();
        }

        private void переплетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Perepletbook> books = new List<Perepletbook>();
            for (int i = 0; i < book.Count; i++)
            {
                books.Add((Perepletbook)book[i]);
            }
            books.Sort();
            book.Clear();
            for (int i = 0; i < books.Count; i++)
            {
                book.Add((BookCreate)books[i]);
            }
            treewiew();
        }

        private void годToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Yearbook> books = new List<Yearbook>();
            for (int i = 0; i < book.Count; i++)
            {
                books.Add((Yearbook)book[i]);
            }
            books.Sort();
            book.Clear();
            for (int i = 0; i < books.Count; i++)
            {
                book.Add((BookCreate)books[i]);
            }
            treewiew();
        }

        private void крСодержаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<KratkoeSoderjbook> books = new List<KratkoeSoderjbook>();
            for (int i = 0; i < book.Count; i++)
            {
                books.Add((KratkoeSoderjbook)book[i]);
            }
            books.Sort();
            book.Clear();
            for (int i = 0; i < books.Count; i++)
            {
                book.Add((BookCreate)books[i]);
            }
            treewiew();
        }

        private void колвоСтраниуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<KolStrbookbook> books = new List<KolStrbookbook>();
            for (int i = 0; i < book.Count; i++)
            {
                books.Add((KolStrbookbook)book[i]);
            }
            books.Sort();
            book.Clear();
            for (int i = 0; i < books.Count; i++)
            {
                book.Add((BookCreate)books[i]);
            }
            treewiew();
        }

        private void поВсемКритериямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Allbook> books = new List<Allbook>();
            for (int i = 0; i < book.Count; i++)
            {
                books.Add((Allbook)book[i]);
            }
            books.Sort();
            book.Clear();
            for (int i = 0; i < books.Count; i++)
            {
                book.Add((BookCreate)books[i]);
            }
            treewiew();
        }


        private void затраченноеВремяНаПрочтениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            for (int i = 0; i < book.Count; i++)
            {
                if (comboBox1.SelectedItem.ToString() == book[i].BookName)
                {
                    this.richTextBox1.Text = Convert.ToString(Math.Round(classbook.TimeBook(book[i].KolvoStranic), 1)) + "ч.";
                }
            }
        }

        private void вКакомВекеНаписанаКнигаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            for (int i = 0; i < book.Count; i++)
            {
                if (comboBox1.SelectedItem.ToString() == book[i].BookName)
                {
                    this.richTextBox1.Text = Convert.ToString(classbook.Vek(book[i].GodVipyska)) + " век";
                }
            }
        }

        private void получитсяПрочитатьКнигуЗаВыходныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            for (int i = 0; i < book.Count; i++)
            {
                if (comboBox1.SelectedItem.ToString() == book[i].BookName)
                {
                    if (book[i])
                    {
                        richTextBox1.Text = "Успеете!";
                    }
                    else
                        richTextBox1.Text = "К сожалению не успеете!";
                }
            }
        }

        private void суммаСтраницВКнигахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            for (int i = 0; i < book.Count; i++)
            {
                for (int j = 0; j < book.Count; j++)
                {
                    if ((comboBox1.SelectedItem.ToString() == book[i].BookName) && (comboBox2.SelectedItem.ToString() == book[j].BookName))
                    {
                        this.richTextBox1.Text = Convert.ToString(book[i] + book[j]);
                    }
                }
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripSplitButton1.Select();
            toolStripSplitButton1.Enabled = true;
            методToolStripMenuItem.Enabled = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            toolStripButton2.Enabled = true;
            поискToolStripMenuItem.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripSplitButton1.Select();
            суммаСтраницВКнигахToolStripMenuItem.Enabled = true;
            суммаСтраницВКнигахToolStripMenuItem1.Enabled = true;
            CпрошломеждунаписаниемдвухкнигToolStripMenuItem1.Enabled = true;
            промежутокМеждуНаписаниемДвухКнигToolStripMenuItem.Enabled = true;
        }

        private void CпрошломеждунаписаниемдвухкнигToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            for (int i = 0; i < book.Count; i++)
            {
                for (int j = 0; j < book.Count; j++)
                {
                    if ((comboBox1.SelectedItem.ToString() == book[i].BookName) && (comboBox2.SelectedItem.ToString() == book[j].BookName))
                    {
                        this.richTextBox1.Text = Convert.ToString(book[i] - book[j]);
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox12.Enabled = false;

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            foreach (char simvol in textBox4.Text)
                if ((!char.IsDigit(simvol)))
                {
                    throw new InvalidOperationException("Поле должно быть типом int");
                }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            foreach (char simvol in textBox13.Text)
                if ((!char.IsDigit(simvol)))
                {
                    throw new InvalidOperationException("Поле должно быть типом int");
                }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            treewiew();
        }
    }
}
