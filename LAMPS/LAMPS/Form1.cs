using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAMPS
{
    public partial class Form1 : Form
    {
        private Leds leds;
        public Form1()
        {
            InitializeComponent();
            leds = new Leds();
            atualizaInterface();
        }
        private void atualizaInterface()
        {
            txtDadoDec.Text = leds.getDado().ToString();
            txtDadoBin.Text = Convert.ToString(leds.getDado(), 2);
            txtDadoHex.Text = Convert.ToString(leds.getDado(), 16).ToUpper();
            btn1.Text = (leds.getLed(1) ? "Off" : "On" );
            btn2.Text = (leds.getLed(2) ? "Off" : "On");
            btn3.Text = (leds.getLed(3) ? "Off" : "On");
            btn4.Text = (leds.getLed(4) ? "Off" : "On");
            btn5.Text = (leds.getLed(5) ? "Off" : "On");
            btn6.Text = (leds.getLed(6) ? "Off" : "On");
            btn7.Text = (leds.getLed(7) ? "Off" : "On");
            btn8.Text = (leds.getLed(8) ? "Off" : "On");
            picBox1.Image = (leds.getLed(1) ? Properties.Resources.ACESA : Properties.Resources.APAGADA);
            picBox2.Image = (leds.getLed(2) ? Properties.Resources.ACESA : Properties.Resources.APAGADA);
            picBox3.Image = (leds.getLed(3) ? Properties.Resources.ACESA : Properties.Resources.APAGADA);
            picBox4.Image = (leds.getLed(4) ? Properties.Resources.ACESA : Properties.Resources.APAGADA);
            picBox5.Image = (leds.getLed(5) ? Properties.Resources.ACESA : Properties.Resources.APAGADA);
            picBox6.Image = (leds.getLed(6) ? Properties.Resources.ACESA : Properties.Resources.APAGADA);
            picBox7.Image = (leds.getLed(7) ? Properties.Resources.ACESA : Properties.Resources.APAGADA);
            picBox8.Image = (leds.getLed(8) ? Properties.Resources.ACESA : Properties.Resources.APAGADA);

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (leds.getLed(1))
            {
                leds.apagar(1);
               
            }
            else
            {
                leds.acender(1);
                
            }
            atualizaInterface();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (leds.getLed(2))
            {
                leds.apagar(2);
            }
            else
            {
                leds.acender(2);
            }
            atualizaInterface();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (leds.getLed(3))
            {
                leds.apagar(3);
            }
            else
            {
                leds.acender(3);
            }
            atualizaInterface();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (leds.getLed(4))
            {
                leds.apagar(4);
            }
            else
            {
                leds.acender(4);
            }
            atualizaInterface();
        }

        private void btn5_Click(object sender, EventArgs e)
        {

            if (leds.getLed(5))
            {
                leds.apagar(5);
            }
            else
            {
                leds.acender(5);
            }
            atualizaInterface();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (leds.getLed(6))
            {
                leds.apagar(6);
            }
            else
            {
                leds.acender(6);
            }
            atualizaInterface();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (leds.getLed(7))
            {
                leds.apagar(7);
            }
            else
            {
                leds.acender(7);
            }
            atualizaInterface();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (leds.getLed(8))
            {
                leds.apagar(8);
            }
            else
            {
                leds.acender(8);
            }
            atualizaInterface();
        }
    }
}
