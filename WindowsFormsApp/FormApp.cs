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
    public partial class FormApp : Form
    {
        public FormApp()
        {
            InitializeComponent();
        }

        private void FormApp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        bool CheckData(out Double so1, out Double so2)
        {
            so1 = 0; so2 = 0;
            if (!Double.TryParse(txta.Text, out so1))
            {
                MessageBox.Show("Invalid value");
                return false;
            }
            if (!Double.TryParse(txtb.Text, out so2))
            {
                MessageBox.Show("Invalid value");
                return false;
            }
            return true;
        }

        public void Basic(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            String tag = button.Tag as String;
            Double so1, so2;
            if (CheckData(out so1, out so2))
            {
                Double kq;
                string display = "";
                var ketqua = so1 + so2;
                if(tag == "+")
                {
                    kq = so1 + so2;
                    display= $"{so1} +{so2} = {ketqua}";
                } else if (tag == "-")
                {
                    kq = so1 - so2;
                    display = $"{so1} - {so2} = {ketqua}";
                }else if (tag == "*")
                {
                    kq = so1 * so2;
                    display = $"{so1} * {so2} = {ketqua}";
                }
                else if(tag == "/")
                {
                    kq = so1 / so2;
                    display = $"{so1} / {so2} = {ketqua}";
                }
                rtbKq.Text = display;




            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var f = new FormTacGia();
            f.ShowDialog();
        }
    }
}
