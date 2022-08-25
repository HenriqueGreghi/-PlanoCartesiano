using System;
using System.Collections.Generic;
using System.Text;

namespace PlanoCartesiano
{
    class Cartesiano
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Plano { get; set; }

        public Cartesiano(int x, int y)
        {
            X = x;
            Y = y;

        }

        public string Parametros()
        {
            if (X > 0 && Y > 0)
            {
                Plano = "Primeiro";
            }
            else if (X < 0 && Y > 0)
            {
                Plano = "Segundo";
            }
            else if (X < 0 && Y < 0)
            {
                Plano = "Terceiro";
            }
            else if (X > 0 && Y < 0)
            {
                Plano = "Quarto";
            }
            return Plano;

            
        }

        
    }
}
