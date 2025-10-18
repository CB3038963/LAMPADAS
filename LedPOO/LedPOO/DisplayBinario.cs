using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedPOO
{
    internal class DisplayBinario
    {
        private List<Leds> leds;
        private TextBox txtvalor;
        private TextBox txtdecimal;

        public DisplayBinario(TextBox txtValor, TextBox txtDecimal)
        {
            this.txtvalor = txtValor;
            this.txtdecimal = txtDecimal;
            leds = new List<Leds>();
        }

        public void AdicionarLed(Leds led)
        {
            leds.Add(led);
        }

        public void AtualizarDisplay()
        {
            var bits = leds.OrderBy(l => l.Posicao)
                          .Select(l => l.ValorBit);

            txtvalor.Text = string.Join("", bits);

            string binarioString = string.Join("", bits);
            int decimalValue = Convert.ToInt32(binarioString, 2);
            txtdecimal.Text = decimalValue.ToString();
        }

        public void AcenderLed(int posicao)
        {
            var led = leds.FirstOrDefault(l => l.Posicao == posicao);
            led?.Acender();
            AtualizarDisplay();
        }

        public void ApagarLed(int posicao)
        {
            var led = leds.FirstOrDefault(l => l.Posicao == posicao);
            led?.Apagar();
            AtualizarDisplay();
        }

        public void LimparTodos()
        {
            foreach (var led in leds)
            {
                led.Apagar();
            }
            AtualizarDisplay();
        }
    }
}
