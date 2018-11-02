using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace rozdzial
{
    public partial class Form5 : Form
    {
        public Encoding enc = Encoding.GetEncoding("Windows-1250");
        int klik = 1;
        public Form5()
        {
            InitializeComponent();
            StreamReader czytaj = new StreamReader("teksty/3.1.txt", enc);
            this.richTextBox1.Text = czytaj.ReadToEnd();
            richTextBox1.Font = new Font("Times New Roman", 14, FontStyle.Regular);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (klik == 2)
            {
                StreamReader czytaj = new StreamReader("teksty/3.3.txt", enc);
                this.richTextBox1.Text = czytaj.ReadToEnd();
                richTextBox1.Font = new Font("Times New Roman", 14, FontStyle.Regular);
                button1.Text = "Miałam dużo na głowie";
                button2.Text = "Psuje mi się telefon";
                button3.Text = "Załatwiam prośby ojca";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = false;
                klik++;
            }
            else
                if (klik == 4)
            {
                StreamReader czytaj = new StreamReader("teksty/3.5.txt", enc);
                this.richTextBox1.Text = czytaj.ReadToEnd();
                richTextBox1.Font = new Font("Times New Roman", 14, FontStyle.Regular);
                button1.Text = "Wróć do spisu treści";
                button3.Text = "Rozdział 4";
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = true;
                button4.Visible = false;
                klik++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (klik == 1)
            {
                StreamReader czytaj = new StreamReader("teksty/3.2a.txt", enc);
                this.richTextBox1.Text = czytaj.ReadToEnd();
                richTextBox1.Font = new Font("Times New Roman", 14, FontStyle.Regular);
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = true;
                klik++;
            }
            else
                if (klik == 3)
            {
                StreamReader czytaj = new StreamReader("teksty/3.4a.txt", enc);
                this.richTextBox1.Text = czytaj.ReadToEnd();
                richTextBox1.Font = new Font("Times New Roman", 14, FontStyle.Regular);
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = true;
                klik++;
            }
            else
            
                this.Close();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (klik == 1)
            {
                StreamReader czytaj = new StreamReader("teksty/3.2c.txt", enc);
                this.richTextBox1.Text = czytaj.ReadToEnd();
                richTextBox1.Font = new Font("Times New Roman", 14, FontStyle.Regular);
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = true;
                klik++;
            }
            else
                if (klik == 3)
            {
                StreamReader czytaj = new StreamReader("teksty/3.4b.txt", enc);
                this.richTextBox1.Text = czytaj.ReadToEnd();
                richTextBox1.Font = new Font("Times New Roman", 14, FontStyle.Regular);
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = true;
                klik++;
            }
            else
            {
                this.Close();
                Form6 rozdzial = new Form6();
                rozdzial.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            if (klik == 1)
            {
                StreamReader czytaj = new StreamReader("teksty/3.2b.txt", enc);
                this.richTextBox1.Text = czytaj.ReadToEnd();
                richTextBox1.Font = new Font("Times New Roman", 14, FontStyle.Regular);
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = true;
                klik++;
            }
            else
                if (klik == 3)
            {
                StreamReader czytaj = new StreamReader("teksty/3.4c.txt", enc);
                this.richTextBox1.Text = czytaj.ReadToEnd();
                richTextBox1.Font = new Font("Times New Roman", 14, FontStyle.Regular);
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = true;
                klik++;
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
