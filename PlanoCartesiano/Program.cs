using System;

namespace PlanoCartesiano
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Entre com a medida do plano cartesiano :");
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            Cartesiano param = new Cartesiano(x,y);

            param.Parametros();
            Console.WriteLine(param.Plano);
            
        }
    }
}
