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
        private DisplayBinario display;
        public Form1()
        {
            InitializeComponent();
            InicializarDisplay();
        }
        private void InicializarDisplay()
        {
            txtvalor.ReadOnly = true;
            txtdecimal.ReadOnly = true;

            // AGORA o new Led() vai funcionar porque a classe Led existe no seu projeto
            display = new DisplayBinario(txtvalor, txtdecimal);

            display.AdicionarLed(new Leds(pictureBox1, 0));
            display.AdicionarLed(new Leds(pictureBox2, 1));
            display.AdicionarLed(new Leds(pictureBox3, 2));
            display.AdicionarLed(new Leds(pictureBox4, 3));
            display.AdicionarLed(new Leds(pictureBox5, 4));
            display.AdicionarLed(new Leds(pictureBox6, 5));
            display.AdicionarLed(new Leds(pictureBox7, 6));
            display.AdicionarLed(new Leds(pictureBox8, 7));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.AcenderLed(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.AcenderLed(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display.AcenderLed(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display.AcenderLed(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display.AcenderLed(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display.AcenderLed(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            display.AcenderLed(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            display.AcenderLed(7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display.ApagarLed(0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            display.ApagarLed(1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            display.ApagarLed(2);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            display.ApagarLed(3);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            display.ApagarLed(4);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            display.ApagarLed(5);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            display.ApagarLed(6);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            display.ApagarLed(7);
        }
    }
}
