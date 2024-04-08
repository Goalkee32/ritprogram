using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ritprogram
{
    public partial class Form1 : Form
    {

        public grej grej = new grej();
        
        public Form1()
        {
            // Initierar programmet. Sätter start pennan till färgen svart och storlek 5. Gör även pennans dragning 
            // smooth och rund.
            InitializeComponent();
            grej.Initialize(panel1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            grej.pbx1(sender);

        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            grej.Down(e, panel1);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            grej.Draw(e);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            grej.Up(e, panel1);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPenna_Click(object sender, EventArgs e)
        {
            grej.Penna(pictureBox1, tbxStorlek);
        }

        private void tbxStorlek_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSudd_Click(object sender, EventArgs e)
        {
            grej.Sudd(pictureBox1, tbxStorlek);
        }

        private void btnEllips_Click(object sender, EventArgs e)
        {
            grej.Ellipse();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grej.btn1(tbxStorlek);
        }

        private void btnRektangel_Click(object sender, EventArgs e)
        {
            grej.Rektangel();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class grej
    {
        Graphics g;
        private bool moving = false;
        private bool penactive = true;
        private bool rectangle = false;
        private bool ellipse = false;
        Pen pen;
        private int x = -1;
        private int y = -1;

        public void Up(MouseEventArgs e, Panel panel1)
        {
            // Om musen rörs bort från ritfältet avaktiveras moving boolen och muspekaren sätts till default igen.
            moving = false;
            x = e.X;
            y = e.Y;
            panel1.Cursor = Cursors.Default;
        }

        public void Down(MouseEventArgs e, Panel panel1)
        {
            // När musen rörs till ritfältet aktiveras moving boolen och x samt y sätts till muspekarens punkt. Muspekaren ändras även till ett kors. 
            moving = true;
            x = e.X;
            y = e.Y;
            panel1.Cursor = Cursors.Cross;
        }

        public void Draw(MouseEventArgs e)
        {
            // När musen rörs händer olika saker beroende på vad användaren valt för målarverktyg. 
            Brush brush = new SolidBrush(pen.Color);
            Rectangle rect = new Rectangle(x, y, x, y);
            if (moving && penactive)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
            if (moving && rectangle)
            {
                g.FillRectangle(brush, rect);
                x = e.X;
                y = e.Y;
            }
            if (moving && ellipse)
            {
                g.FillEllipse(brush, rect);
                x = e.X;
                y = e.Y;
            }
        }

        public void Penna(PictureBox pictureBox1, TextBox tbxStorlek)
        {
            // När Penna knappen trycks ner aktiveras pen verktyget och färgen samt storleken sätts till den angivna storleken.
            rectangle = false;
            ellipse = false;
            penactive = true;
            pen = new Pen(pen.Color, int.Parse(tbxStorlek.Text));
            pictureBox1.BackColor = Color.Black;
            pen.Color = pictureBox1.BackColor;
        }

        public void Sudd(PictureBox pictureBox1, TextBox tbxStorlek)
        {
            // När Sudd knappen trycks in byts färgen till vit på pennan, samma som bakgrunden.
            rectangle = false;
            ellipse = false;
            penactive = true;
            pen = new Pen(Color.White, int.Parse(tbxStorlek.Text));
            pictureBox1.BackColor = Color.White;
        }

        public void Ellipse()
        {
            // När Ellips knappen klickas så aktiveras ellipsverktyget.
            penactive = false;
            rectangle = false;
            ellipse = true;
        }

        public void btn1(TextBox tbxStorlek)
        {
            // Apply knappen för storleken på pennan. När denna klickas uppdateras pennans storlek.
            pen = new Pen(pen.Color, int.Parse(tbxStorlek.Text));
        }

        public void Rektangel()
        {
            // När Rektangel knappen klickas så aktiveras rektangelverktyget. 
            penactive = false;
            ellipse = false;
            rectangle = true;
        }

        public void pbx1(object sender)
        {
            // För att sätta färgen på pennan. Den färg som användaren klickar på sätts from pennans färg.
            PictureBox p = (PictureBox)sender;
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                p.BackColor = c.Color;


            }
            pen.Color = c.Color;
        }

        public void Initialize(Panel panel1)
        {
            g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
    }

}
