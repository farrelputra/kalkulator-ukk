using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_Nisrina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            LBLhasil.Text = "";
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 Harus Diisi Terlebih Dahulu");
            }
            else
            {
                double a, b, c;
                a = double.Parse(this.textBox1.Text);
                b = double.Parse(this.textBox2.Text);
                c = a + b;
                this.LBLhasil.Text = c.ToString();
            }
                
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 Harus Diisi Terlebih Dahulu");
            }
            else
            {
                double a, b, c;
                a = double.Parse(this.textBox1.Text);
                b = double.Parse(this.textBox2.Text);
                c = a / b;
                this.LBLhasil.Text = c.ToString();
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            LBLhasil.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 Harus Diisi Terlebih Dahulu");
            }
            else
            {
                double a, b, c;
                a = double.Parse(this.textBox1.Text);
                b = double.Parse(this.textBox2.Text);
                c = a - b;
                this.LBLhasil.Text = c.ToString();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 Harus Diisi Terlebih Dahulu");
            }
            else
            {
                double a, b, c;
                a = double.Parse(this.textBox1.Text);
                b = double.Parse(this.textBox2.Text);
                c = a * b;
                this.LBLhasil.Text = c.ToString();
            }
        }
    }
}
