using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_I_10_all
{
    public partial class NewDataGridView : UserControl
    {
        public Color BackColorN { get; set; } = Color.LightBlue;
        public Color BackColorM { get; set; } = Color.LightBlue;
        public Color BackColorTable { get; set; } = Color.Lavender;
        public Color BorderColor { get; set; } = Color.DodgerBlue;
        public Color SetkaColor { get; set; } = Color.DarkBlue;
        public Color RowsHeaderColor { get; set; } = Color.CornflowerBlue;
        public Color ColumnsHeaderColor { get; set; } = Color.CornflowerBlue;

        public Color CellsColor { get; set; } = Color.LightBlue;



        public NewDataGridView()
        {
            InitializeComponent();
        }

        private void NewDataGridView_Load(object sender, EventArgs e)
        {
            Table.AllowUserToAddRows = false;
            n.ReadOnly = true;
            m.ReadOnly = true;
            n.BackColor = BackColorN;
            m.BackColor = BackColorM;
            Table.BackgroundColor = BackColorTable;
            Table.BorderStyle = BorderStyle.None;
            Table.GridColor = SetkaColor;
            Table.EnableHeadersVisualStyles = false;
            Table.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            Table.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            Table.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            Table.ColumnHeadersDefaultCellStyle.BackColor = ColumnsHeaderColor;
            Table.RowHeadersDefaultCellStyle.BackColor = RowsHeaderColor;
            Table.RowsDefaultCellStyle.BackColor = CellsColor;
            Table.AlternatingRowsDefaultCellStyle.BackColor = CellsColor;

        }


        private void n_SelectedItemChanged(object sender, EventArgs e)
        {
            Table.RowCount = Convert.ToInt32(n.Text);
            if (Convert.ToInt32(n.Text) == 1)
                m.Text = n.Text;
            for (int i = 0; i < Table.RowCount; i++)
                Table.Rows[i].HeaderCell.Value = Convert.ToString(i + 1);
        }

        private void m_SelectedItemChanged(object sender, EventArgs e)
        {
            Table.ColumnCount = Convert.ToInt32(m.Text);
            for (int i = 0; i < Table.ColumnCount; i++)
                Table.Columns[i].Name = Convert.ToString(i + 1);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics grapfic = e.Graphics;
            Rectangle rectBaseTable = new Rectangle(Table.Left-1, Table.Top-1, Table.Width + 1, Table.Height + 1);
            grapfic.DrawRectangle(new Pen(BorderColor), rectBaseTable);

            Rectangle rectBaseN = new Rectangle(n.Left - 1, n.Top - 1, n.Width + 1, n.Height + 1);
            grapfic.DrawRectangle(new Pen(BorderColor), rectBaseN);

            Rectangle rectBaseM = new Rectangle(m.Left - 1, m.Top - 1, m.Width + 1, m.Height + 1);
            grapfic.DrawRectangle(new Pen(BorderColor), rectBaseM);
        }
    }
}
