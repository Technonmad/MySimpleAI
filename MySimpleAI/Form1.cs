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
        IfBusy busy = new IfBusy();
        WannaSleep sleep = new WannaSleep();
        IfRead read = new IfRead();
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
            else
            {
                if (busy.checkBusy(radioButton4.Checked, radioButton7.Checked))
                    textBox1.Text = "Вам нужно сделать дз и дела по дому!";
                else
                {
                    if (sleep.checkSleep(radioButton2.Checked, radioButton3.Checked, radioButton12.Checked))
                        textBox1.Text = "Вам следует пойти спать!";
                    else
                    {
                        if (read.checkRead(radioButton2.Checked, radioButton3.Checked, radioButton5.Checked, radioButton6.Checked, radioButton8.Checked, radioButton9.Checked, radioButton11.Checked, radioButton12.Checked))
                            textBox1.Text = "Вы можете почитать книгу!";
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
