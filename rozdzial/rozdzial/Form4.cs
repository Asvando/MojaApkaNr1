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
    public partial class Form4 : Form
    {
        public Encoding enc = Encoding.GetEncoding("Windows-1250");
        int klik = 1;
        public Form4()
        {
            InitializeComponent();

            StreamReader czytaj = new StreamReader("teksty/2.1.txt", enc);
            this.richTextBox1.Text = czytaj.ReadToEnd();
            richTextBox1.Font = new Font("Times New Roman", 14, FontStyle.Regular);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (klik == 1)
            {
                StreamReader czytaj = new StreamReader("teksty/2.2.txt", enc);
                this.richTextBox1.Text = czytaj.ReadToEnd();
                richTextBox1.Font = new Font("Times New Roman", 14, FontStyle.Regular);
                button1.Visible = false;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = false;
            }

            else
                if (klik == 3)
            {
                StreamReader czytaj = new StreamReader("teksty/2.5.txt", enc);
                this.richTextBox1.Text = czytaj.ReadToEnd();
                richTextBox1.Font = new Font("Times New Roman", 14, FontStyle.Regular);
                button2.Text = "'Mój ojciec nie żyje, doktorze'";
                button1.Text = "'Niech pan złoży mu go osobiście na grobie'";
                button3.Text = "'Nie jestem listonoszem pomiędzy światem żywych i martwych'";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = false;
            }
            else
            {
                StreamReader czytaj = new StreamReader("teksty/2.7.txt", enc);
                this.richTextBox1.Text = czytaj.ReadToEnd();
                richTextBox1.Font = new Font("Times New Roman", 14, FontStyle.Regular);
                button2.Text = "Powrót do spisu treści";
                button3.Text = "Rozdział 3";
                button1.Visible = false;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (klik == 2)
            {
                StreamReader czytaj = new StreamReader("teksty/2.4b.txt", enc);
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
                StreamReader czytaj = new StreamReader("teksty/2.6b.txt", enc);
                this.richTextBox1.Text = czytaj.ReadToEnd();
                richTextBox1.Font = new Font("Times New Roman", 14, FontStyle.Regular);
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = true;
                klik++;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (klik == 1)
            {
                StreamReader czytaj = new StreamReader("teksty/2.3b.txt", enc);
                this.richTextBox1.Text = czytaj.ReadToEnd();
                richTextBox1.Font = new Font("Times New Roman", 14, FontStyle.Regular);

                button2.Text = "'Już w porządku, nic się nie stało'";
                button1.Text = "'Oby ten rowerzysta miał takie samo szczęście, co ja'";
                button3.Text = "'Uważaj, jak chodzisz!'";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = false;
                klik++;
            }
            else
                   if (klik == 2)
            {
                StreamReader czytaj = new StreamReader("teksty/2.4a.txt", enc);
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
                StreamReader czytaj = new StreamReader("teksty/2.6a.txt", enc);
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
                StreamReader czytaj = new StreamReader("teksty/2.3a.txt", enc);
                this.richTextBox1.Text = czytaj.ReadToEnd();
                richTextBox1.Font = new Font("Times New Roman", 14, FontStyle.Regular);
                button2.Text = "'Już w porządku, nic się nie stało'";
                button1.Text = "'Oby ten rowerzysta miał takie samo szczęście, co ja'";
                button3.Text = "'Uważaj, jak chodzisz!'";
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = false;
                klik++;
            }
            else
                   if (klik == 2)
            {
                StreamReader czytaj = new StreamReader("teksty/2.4c.txt", enc);
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
            {     StreamReader czytaj = new StreamReader("teksty/2.6c.txt", enc);
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
                Form5 rozdzial = new Form5();
                rozdzial.Show();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
