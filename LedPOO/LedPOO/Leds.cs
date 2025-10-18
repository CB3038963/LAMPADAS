using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedPOO
{
    internal class Leds
    {
        public System.Windows.Forms.PictureBox PictureBox { get; private set; }
        public int Posicao { get; private set; }
        public bool Estado { get; private set; }
        public int ValorBit => Estado ? 1 : 0;

        public Leds(System.Windows.Forms.PictureBox pictureBox, int posicao)
        {
            PictureBox = pictureBox;
            Posicao = posicao;
            Estado = false;
            AtualizarImagem();
        }

        public void Acender()
        {
            Estado = true;
            AtualizarImagem();
        }

        public void Apagar()
        {
            Estado = false;
            AtualizarImagem();
        }

        public void Alternar()
        {
            Estado = !Estado;
            AtualizarImagem();
        }

        private void AtualizarImagem()
        {
            PictureBox.Image = Estado ?
                Properties.Resources.ACESA :
                Properties.Resources.APAGADA;
        }
    }
}

