using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySimpleAI
{
    public partial class Form1 : Form
    {
        IfTarkov tarkov = new IfTarkov();
        public Form1()
        {
            InitializeComponent();
            progressBar1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tarkov.CheckTarkov(radioButton1.Checked, radioButton5.Checked, radioButton8.Checked, radioButton10.Checked))
                textBox1.Text = "Вам стоит поиграть в Eskape from Krakov";
        }
    }
}
