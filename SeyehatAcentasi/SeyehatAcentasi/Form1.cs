using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SeyehatAcentasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            listBox2.Items.Add(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(button6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(button7.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(textBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox5.Items.Add(comboBox1.Text);
            listBox6.Items.Add(radioButton1.Text);
            listBox6.Items.Add(radioButton2.Text);
            listBox7.Items.Add(comboBox2.Text);
            listBox1.Text = "Ali Rıza";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();           
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

    }
}
