using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;
using System.Diagnostics;
using static System.Windows.Forms.AxHost;
using System.Timers;

namespace P_I_10_all
{
    public class Pechat : Control
    {

        private StringFormat SF = new StringFormat();
        private Stopwatch timer = new Stopwatch();
        public string time { get; set; }
        private string TextPrew { get; set; } = "Секундомер";

        private int SmechenieForPrew = 0;
        private bool Backspace = false;
        private bool timerGo = true;
        private TextBox textboxInput = new TextBox();
        public Font FontText { get; set; } = new Font("Arial", 8, FontStyle.Bold);
        public Color BorderColor { get; set; } = Color.DodgerBlue;
        public Color ColorPrew { get; set; } = Color.DodgerBlue;

        public Pechat()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            Size = new Size(300, 40);
            Font = new Font("Arial", 11.25F, FontStyle.Regular);
            BackColor = Color.Lavender;
            ForeColor = Color.Black;
            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;
            AbjustTextBoxInput();
            this.Controls.Add(textboxInput);
        }
        private void AbjustTextBoxInput()
        {
            textboxInput = new TextBox();
            textboxInput.Name = "Pechat";
            textboxInput.BorderStyle = BorderStyle.None;
            textboxInput.Font = Font;
            textboxInput.ForeColor = ForeColor;
            textboxInput.BackColor = BackColor;
            int Smechenie = TextRenderer.MeasureText(TextPrew, FontText).Height / 2;
            textboxInput.Location = new Point(5, Height / 2 - Smechenie);
            textboxInput.Size = new Size(Width - 10, textboxInput.Height);
            textboxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnter);
            textboxInput.TextChanged += textbox_TextChanged;
        }
        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)8)
                Backspace = true;
            else
                Backspace = false;
            if (e.KeyChar == (char)13)
            {
                timer.Stop();
                timerGo = true;
                TimeSpan timeSpan = timer.Elapsed;
                time = timeSpan.ToString(@"m\:ss\.fff");
                timer.Reset();
            }
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            Text = textboxInput.Text;
            if ((!Backspace) & (timerGo))
            {
                timer.Start();
                timerGo = false;
            }

        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            textboxInput.BackColor = BackColor;
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            textboxInput.ForeColor = ForeColor;

        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            textboxInput.Font = Font;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics grapfic = e.Graphics;
            grapfic.SmoothingMode = SmoothingMode.HighQuality;
            grapfic.Clear(Parent.BackColor);
            SmechenieForPrew = grapfic.MeasureString(TextPrew, FontText).ToSize().Height / 2;
            Rectangle rectBase = new Rectangle(0, SmechenieForPrew, Width - 1, Height - 1 - SmechenieForPrew);
            Size TextPrewSize = grapfic.MeasureString(TextPrew, FontText).ToSize();
            Rectangle rectTextPrew = new Rectangle(5, 0, TextPrewSize.Width, TextPrewSize.Height);
            grapfic.DrawRectangle(new Pen(BorderColor), rectBase);

            grapfic.DrawRectangle(new Pen(Parent.BackColor), rectTextPrew);
            grapfic.FillRectangle(new SolidBrush(Parent.BackColor), rectTextPrew);

            grapfic.FillRectangle(new SolidBrush(BackColor), rectBase);

            grapfic.DrawString(TextPrew, FontText, new SolidBrush(ColorPrew), rectTextPrew, SF);
        }

    }
}
