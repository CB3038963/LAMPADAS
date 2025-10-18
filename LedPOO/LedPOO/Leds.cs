using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedPOO
{
    internal class Leds
    {
        private byte dado;
        //construtor
        public Leds()
        {
            this.dado = 0;
        }
        public Leds(byte dado)
        {
            this.dado = dado;
        }
        //acender
        public void acender (int led)
        {
            if (led >=0 && led < 8)
            {
                dado |= (byte)(1<<led);
                    
            }
        }
        //apagar
        public void apagar (int led)
        {
            dado &= (byte)~(1 << led);
        }
        //retornar o dado
        public byte getdado()
        {
            return dado;
        }
        //verificar
        public bool getled(int led)
        {
            if(led >=0 && led<8)
            {
                return (dado & (1 << led)) != 0;
            }       
            return false;
        }
    }
}
