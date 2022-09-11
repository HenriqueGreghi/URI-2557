using System;
using System.Collections.Generic;
using System.Text;

namespace Uri_2557
{
    class Calculo
    {
        public string Valor1 { get; set; }
        public string Valor2 { get; set; }
        public string Valor3 { get; set; }

        public void Valor(string Valor1, string Valor2, string Valor3)
        {
            if (Valor3 == "J")
            {
                int R = int.Parse(Valor1);
                int L = int.Parse(Valor2);

                int J = R + L;
                Console.WriteLine(J);

            }
            else if (Valor2 == "L")
            {
                int R = int.Parse(Valor1);
                int J = int.Parse(Valor3);

                int L = R - J;
                Console.WriteLine(L);

            }
            if (Valor1 == "R")
            {
                int J = int.Parse(Valor3);
                int L = int.Parse(Valor2);

                int R = J - L;
                Console.WriteLine(R);

            }
        }
    }
}
