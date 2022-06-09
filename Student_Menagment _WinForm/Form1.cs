using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Menagment__WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username=textBox1.Text;
            string password=textBox2.Text;
            if(username=="Admin" && password=="1234")
            {
                MessageBox.Show("Login Success");
                MDIParent1 m = new MDIParent1();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Fail");
            }
        }
    }
}
