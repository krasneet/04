using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a,b,c;

            bool rez1 = int.TryParse(textBox1.Text, out a);

            if (rez1 == false)
            {
                MessageBox.Show("Неверный формат числа" + textBox1.Text + "!");
                return;
            }

            bool rez2 = int.TryParse(textBox2.Text, out b);

            if (rez1 == false)
            {
                MessageBox.Show("Неверный формат числа" + textBox1.Text + "!");
                return;
            }

            c = (3 * a + 12 * b)/3;
            string cStr = c.ToString();
            otvet.Text = cStr;
            return;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Y_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void otvet_Click(object sender, EventArgs e)
        {

        }
    }
}
