using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMPS
{
    internal class Leds
    {
        private byte dado;
        public Leds()
        {
            this.dado = 0;
        }
        private Leds(byte dado)
        {
            this.dado = dado;
        }
        public void acender(int led)
        {
            int ou = (int)(Math.Pow(2, led - 1));
            this.dado = (byte)((int)(this.dado) | ou);
        }
        public void apagar(int led)
        {
            int e = (int)(255 - Math.Pow(2, led - 1));
            this.dado = (byte)((int)(this.dado) & e);
        }
        public byte getDado()
        {
            return this.dado;
        }
        public bool getLed(int led)
        {
            byte checar;
            int e = (int)(Math.Pow(2, led - 1));
            checar = (byte)((int)(this.dado) & e);
            return (checar > 0);
        }

     
    }
}
