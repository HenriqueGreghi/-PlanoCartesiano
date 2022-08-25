using System;

namespace PlanoCartesiano
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartesiano param = new Cartesiano();

            Console.WriteLine("Entre com a medida do plano cartesiano :");
            string[] valores = Console.ReadLine().Split(' ');
            param.x = int.Parse(valores[0]);
            param.y = int.Parse(valores[1]);

            param.Parametros();
            param.Imprimir();
        }
    }
}
