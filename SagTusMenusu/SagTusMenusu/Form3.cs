using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SagTusMenusu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.ForeColor=Color.Pink;
            progressBar2.ForeColor=Color.Green;
            progressBar3.ForeColor=Color.Orange;
            progressBar1.Value = 30;
            progressBar2.Value = 60;
            progressBar3.Value = 40;
        }
    }
}
