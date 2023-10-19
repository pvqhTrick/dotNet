using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = long.Parse(textBox1.Text);
            var b = long.Parse(textBox2.Text);
            var kq = a + b;
            String str = $"{a} + {b} = {kq}";
            MessageBox.Show(str);
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            var a = long.Parse(textBox1.Text);
            var b = long.Parse(textBox2.Text);
            var kq = a - b;
            String str = $"{a} - {b} = {kq}";
            MessageBox.Show(str);
        }
    }
}
