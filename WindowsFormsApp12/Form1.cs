using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 60;
        int dogru = 0;
        int yanlis = 0;
        string[] k = { "Kırmızı", "Sarı", "Yeşil" };
        List<Color> renk = new List<Color>();
        Random r = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible= true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = false;
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            renk.Add(Color.Red);
            renk.Add(Color.Yellow);
            renk.Add(Color.Green);
            label2.Text = k[r.Next(k.Length)];
            label2.ForeColor = renk[r.Next(renk.Count)];
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            pictureBox1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = sayac.ToString();
            sayac--;
            if(sayac==-1)
            {
                timer1.Enabled = false;
                MessageBox.Show("Doğru Sayınız:"+dogru+","+"Yanlış Sayınız:"+yanlis);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Kırmızı" && label2.ForeColor == Color.Red)
            {
                pictureBox1.Visible = true;
                timer2.Enabled = true;
                dogru++;
                pictureBox1.Image = Properties.Resources.tic_verde_png;
            }
            else if (label2.Text == "Sarı" && label2.ForeColor == Color.Yellow)
            {
                pictureBox1.Visible = true;
                timer2.Enabled = true;
                dogru++;
                pictureBox1.Image = Properties.Resources.tic_verde_png;
            }
            else if (label2.Text == "Yeşil" && label2.ForeColor == Color.Green)
            {
                pictureBox1.Visible = true;
                timer2.Enabled = true;
                dogru++;
                pictureBox1.Image = Properties.Resources.tic_verde_png;
            }
            else
            {
                pictureBox1.Visible = true;
                timer2.Enabled = true;
                yanlis++;
                pictureBox1.Image = Properties.Resources.x_rossa_png_2 ;
            }
            label2.Text = k[r.Next(k.Length)];
            label2.ForeColor = renk[r.Next(renk.Count)];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Kırmızı" && label2.ForeColor != Color.Red)
            {
                pictureBox1.Visible = true;
                timer2.Enabled = true;
                dogru++;
                pictureBox1.Image = Properties.Resources.tic_verde_png;
            }
            else if (label2.Text == "Sarı" && label2.ForeColor != Color.Yellow)
            {
                pictureBox1.Visible = true;
                timer2.Enabled = true;
                dogru++;
                pictureBox1.Image = Properties.Resources.tic_verde_png;
            }
            else if (label2.Text == "Yeşil" && label2.ForeColor != Color.Green)
            {
                pictureBox1.Visible = true;
                timer2.Enabled = true;
                dogru++;
                pictureBox1.Image = Properties.Resources.tic_verde_png;
            }
            else
            {
                pictureBox1.Visible = true;
                timer2.Enabled = true;
                yanlis++;
                pictureBox1.Image = Properties.Resources.x_rossa_png_2;
            }
            label2.Text = k[r.Next(k.Length)];
            label2.ForeColor = renk[r.Next(renk.Count)];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            timer2.Enabled = false;
        }
    }
}
