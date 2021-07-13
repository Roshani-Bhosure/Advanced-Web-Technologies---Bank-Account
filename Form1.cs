using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account
{
    public partial class Form1 : Form
    {
        account obj = new account();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label4.Visible = false;
            textBox4.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.open(int.Parse(textBox3.Text));
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            label4.Visible = true;
            textBox4.Visible = true;
            button1.Visible = false;
            label3.Visible = false;
            textBox3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj.withdraw(int.Parse(textBox4.Text));
            textBox4.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            obj.deposit(int.Parse(textBox4.Text));
            textBox4.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            obj.checkbalance();
        }
    }
}
