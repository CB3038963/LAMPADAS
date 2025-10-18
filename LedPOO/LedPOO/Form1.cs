using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedPOO
{
    public partial class Form1 : Form
    {
        private Leds led;
        public Form1()
        {
            InitializeComponent();
            led = new Leds();
            txtvalor.ReadOnly = true;
            txtdecimal.ReadOnly = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.ACESA;
            led.acender(0);
            atualizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.ACESA;
            led.acender(1);
            atualizar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.ACESA;
            led.acender(2);
            atualizar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.ACESA;
            led.acender(3);
            atualizar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.ACESA; 
            led.acender(4);
            atualizar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.ACESA;
            led.acender(5);
            atualizar();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.ACESA;
            led.acender(6);
            atualizar();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.ACESA;
            led.acender(7);
            atualizar();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.APAGADA;
            led.apagar(0);
            atualizar();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.APAGADA;
            led.apagar(1);
            atualizar();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.APAGADA;
            led.apagar(2);
            atualizar();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.APAGADA;
            led.apagar(3);
            atualizar();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.APAGADA;
            led.apagar(4);
            atualizar();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.APAGADA;
            led.apagar(5);
            atualizar();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.APAGADA;   
            led.apagar(6);
            atualizar();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.APAGADA;
            led.apagar(7);
            atualizar();
        }
        private void atualizar()
        {
            byte valor = led.getdado();
            txtvalor.Text = Convert.ToString(valor, 2).PadLeft(8, '0');
            txtdecimal.Text = valor.ToString();
            atualizarImagens();
        }
        private void atualizarImagens()
        {
            pictureBox1.Image = led.getled(0) ? Properties.Resources.ACESA : Properties.Resources.APAGADA;
            pictureBox2.Image = led.getled(1) ? Properties.Resources.ACESA : Properties.Resources.APAGADA;
            pictureBox3.Image = led.getled(2) ? Properties.Resources.ACESA : Properties.Resources.APAGADA;
            pictureBox4.Image = led.getled(3) ? Properties.Resources.ACESA : Properties.Resources.APAGADA;
            pictureBox5.Image = led.getled(4) ? Properties.Resources.ACESA : Properties.Resources.APAGADA;
            pictureBox6.Image = led.getled(5) ? Properties.Resources.ACESA : Properties.Resources.APAGADA;
            pictureBox7.Image = led.getled(6) ? Properties.Resources.ACESA : Properties.Resources.APAGADA;
            pictureBox8.Image = led.getled(7) ? Properties.Resources.ACESA : Properties.Resources.APAGADA;
        }
    }
}
