using System;

namespace Uri_2557
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com  quantidade de teste: ");
            int teste = int.Parse(Console.ReadLine());

            for (int i = 0; i < teste; i++)
            {
                Console.WriteLine( "Digite o teste:");
                string[] testes = Console.ReadLine().Split("+");
                string valor1 = (testes[0]);
                string[] valores = testes[1].Split("=");
                string valor2 = valores[0];
                string valor3 = valores[1];

                Calculo calc = new Calculo();
                calc.Valor(valor1,valor2,valor3);

            }

        }
    }
}
