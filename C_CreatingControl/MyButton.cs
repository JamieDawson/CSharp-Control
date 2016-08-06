using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_CreatingControl
{
    public partial class MyButton : UserControl
    {
        public MyButton()
        {
            InitializeComponent();
        }
        string text = "";
        protected override void OnPaint(PaintEventArgs e)
        {
            DrawButton(Color.FromKnownColor(KnownColor.Control));
        }

        public string ButtonText
        {
            get { return text; }
            set { text = value; }
        }

        private void MyButton_MouseHover(object sender, EventArgs e)
        {
            Color myColor = Color.FromArgb(225, Color.FromKnownColor(KnownColor.Control).R - 30, Color.FromKnownColor(KnownColor.Control).R - 5, 255);
            DrawButton(myColor);
        }       
        void DrawButton(Color c)
        {
            SolidBrush s = new SolidBrush(c);
            Graphics g = this.CreateGraphics();
            g.FillRectangle(s, 0, 0, this.Width, this.Height);
            s.Color = Color.FromArgb(225, c.R - 13, c.G - 13, c.B - 13);
            g.FillRectangle(s, 0, this.Height / 2, this.Width, this.Height / 2);
            PointF fpoint = new Point((this.Width / 2) - (text.Length - 5), (this.Height / 2) - (text.Length - 5));
            FontFamily ff = new FontFamily("Arial");
            Font f = new System.Drawing.Font(ff, 8);
            s.Color = Color.Black;
            g.DrawString(text, f, s, fpoint);
        }

        private void MyButton_MouseLeave(object sender, EventArgs e)
        {
            DrawButton(Color.FromKnownColor(KnownColor.Control));
        }

        private void MyButton_MouseEnter(object sender, EventArgs e)
        {
            Color myColor = Color.FromArgb(225, Color.FromKnownColor(KnownColor.Control).R - 30, Color.FromKnownColor(KnownColor.Control).R - 5, 255);
            DrawButton(myColor);
        }
        //Changes the color of the button to yellow when clicked.
        private void MyButton_MouseDown(object sender, MouseEventArgs e)
        {
            Color myColor = Color.FromArgb(255, Color.FromKnownColor(KnownColor.Control).R + 15, Color.FromKnownColor(KnownColor.Control).G - 15, 150);
            DrawButton(myColor);
        }
    }
}

