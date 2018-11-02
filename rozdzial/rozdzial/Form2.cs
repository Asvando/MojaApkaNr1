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

    // tablica o niekoreskolny rozmiarze dwuwymiarowa
    public partial class Form2 : Form
    {
        public Encoding enc = Encoding.GetEncoding("Windows-1250");
        public static int test = 4; // to przetestowania, nic konkretnego nie robi
        int klik = 1;
        public Form2()
        {
            InitializeComponent();

            StreamReader czytaj = new StreamReader("teksty/1.1.txt", enc);
            this.richTextBox1.Text = czytaj.ReadToEnd();

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (klik == 1)
            {
                StreamReader czytaj = new StreamReader("teksty/1.2.txt", enc);
                this.richTextBox1.Text = czytaj.ReadToEnd();
                richTextBox1.Font = new Font("Times New Roman", 14, FontStyle.Regular);
                button2.Text = "a) 'Nie wynieram się na bal przebierańców, jeśli o to pytasz.'";
                button3.Text = "b) 'Masz z tym jakiś problem?'";
                button4.Text = "c) <przemilcz>";
                button1.Visible = false;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                
            }
            else 
            if (klik == 2)
            {         
                StreamReader czytaj = new StreamReader("teksty/1.4.txt", enc);
                this.richTextBox1.Text = czytaj.ReadToEnd();
                button2.Text = "a) 'Będę o tym pamiętać.'";
                button3.Text = "b) 'Z tym ostatnim muszę się zgodzić.'";
                button4.Text = "c) 'Mówisz tak, jakbyście byli bez winy.";
                button1.Visible = false;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;

            }
            else if (klik ==3)
            {
                StreamReader czytaj = new StreamReader("teksty/1.6.txt", enc);
                this.richTextBox1.Text = czytaj.ReadToEnd();
                klik++;
            }
            else
            {
                StreamReader czytaj = new StreamReader("teksty/1.7.txt", enc);
                this.richTextBox1.Text = czytaj.ReadToEnd();
                button1.Visible = false;
                klik++;
                button5.Visible = true;
                button6.Visible = true;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (klik == 1)
            {
                StreamReader czytaj = new StreamReader("teksty/1.3a.txt", enc);
                this.richTextBox1.Text = czytaj.ReadToEnd();
                klik++;
                ClassLibrary2.Louise.ironia = +1;
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
            else if (klik==2)
            {
                StreamReader czytaj = new StreamReader("teksty/1.5a.txt", enc);
                this.richTextBox1.Text = czytaj.ReadToEnd();
                klik++;
                ClassLibrary2.Louise.taktownosc = +1;
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (klik == 1)
            {
                StreamReader czytaj = new StreamReader("teksty/1.3b.txt", enc);
                this.richTextBox1.Text = czytaj.ReadToEnd();
                klik++;
                ClassLibrary2.Louise.bunt = +1;
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
            else if (klik == 2)
            {
                StreamReader czytaj = new StreamReader("teksty/1.5b.txt", enc);
                this.richTextBox1.Text = czytaj.ReadToEnd();
                klik++;
                ClassLibrary2.Louise.ironia = +1;
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (klik == 1)
            {
                StreamReader czytaj = new StreamReader("teksty/1.3c.txt", enc);
                this.richTextBox1.Text = czytaj.ReadToEnd();
                klik++;
                ClassLibrary2.Louise.statycznosc = +1;
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
            else if (klik == 2)
            {
                StreamReader czytaj = new StreamReader("teksty/1.5c.txt", enc);
                this.richTextBox1.Text = czytaj.ReadToEnd();
                klik++;
                ClassLibrary2.Louise.bunt = +1;
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 rozdzial = new Form4();
            rozdzial.Show();


        }
    }
}
