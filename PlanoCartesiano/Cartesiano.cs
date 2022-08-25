using System;
using System.Collections.Generic;
using System.Text;

namespace PlanoCartesiano
{
    class Cartesiano
    {
        public int x { get; set; }
        public int y { get; set; }
        private string plano { get; set; }

        public void Parametros()
        {
            if (x > 0 && y > 0)
            {
                plano = "Primeiro";
            }
            else if (x < 0 && y > 0)
            {
                plano = "Segundo";
            }
            else if (x < 0 && y < 0)
            {
                plano = "Terceiro";
            }
            else if (x > 0 && y < 0)
            {
                plano = "Quarto";
            }
            else
            {

            }

        }

        public void Imprimir()
        {
            Console.WriteLine(plano);
        }
    }
}
