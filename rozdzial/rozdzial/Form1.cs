using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;

namespace rozdzial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Form2 rozdzial = new Form2();
            rozdzial.Show();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Form3 rozdzial = new Form3();
            rozdzial.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 rozdzial = new Form4();
            rozdzial.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 rozdzial = new Form5();
            rozdzial.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 rozdzial = new Form6();
            rozdzial.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
