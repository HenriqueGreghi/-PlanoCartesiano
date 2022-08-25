using System;
using System.Collections.Generic;
using System.Text;

namespace PlanoCartesiano
{
    class Cartesiano
    {
        private int X { get; set; }
        private int Y { get; set; }
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
               return "Primeiro";
            }
            else if (X < 0 && Y > 0)
            {
                return "Segundo";
            }
            else if (X < 0 && Y < 0)
            {
                return "Terceiro";
            }
            else if (X > 0 && Y < 0)
            {
                return "Quarto";
            }
            return "Não definido";

            
        }

        
    }
}
