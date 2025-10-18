using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Led
{
    public partial class Form1 : Form
    {
       
        int[] valor = new int[8]{0,0,0,0,0,0,0,0};
        public Form1()
        {
            InitializeComponent();

            txtvalor.ReadOnly = true;
            txtdecimal.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.ACESA;
            valor[0] =  1;
            AtualizarDisplay();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.ACESA;
            valor[1] = 1;
            AtualizarDisplay();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.ACESA;
            valor[2] = 1;
            AtualizarDisplay();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.ACESA;
            valor[3] = 1;
            AtualizarDisplay();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.ACESA;
            valor[4] = 1;
            AtualizarDisplay();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.ACESA;
            valor[5] = 1;
            AtualizarDisplay();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.ACESA;
            valor[6] = 1;
            AtualizarDisplay();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.ACESA;
            valor[7] = 1;
            AtualizarDisplay();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.APAGADA;
            valor[0] = 0;
            AtualizarDisplay();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.APAGADA;
            valor[1] = 0;
            AtualizarDisplay();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.APAGADA;
            valor[2] = 0;
            AtualizarDisplay();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.APAGADA;
            valor[3] = 0;
            AtualizarDisplay();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.APAGADA;
            valor[4] = 0;
            AtualizarDisplay();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.APAGADA;
            valor[5] = 0;
            AtualizarDisplay();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.APAGADA;
            valor[6] = 0;
            AtualizarDisplay();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.APAGADA;
            valor[7] = 0;
            AtualizarDisplay();
        }

        private void AtualizarDisplay()
        {
            txtvalor.Text = string.Join("", valor);


            string binarioString = string.Join("", valor);
            int decimalValue = Convert.ToInt32(binarioString, 2);
            txtdecimal.Text = decimalValue.ToString();
        }


    }
}
