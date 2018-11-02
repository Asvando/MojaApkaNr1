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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Encoding enc = Encoding.GetEncoding("Windows-1250");
            StreamReader czytaj = new StreamReader("teksty/prolog.txt", enc);
            this.richTextBox1.Text = czytaj.ReadToEnd();
            richTextBox1.Font = new Font("Times New Roman", 14, FontStyle.Regular);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 rozdzial = new Form2();
            rozdzial.Show();
            
        }
    }
}
