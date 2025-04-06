using System;

namespace FGTS
{
    class Progam
    {
        static void Main(string[] args)
        {
            double salario, fgts;

            Console.WriteLine("Digite seu salário para calcular seu FGTS.");
            salario = Convert.ToDouble(Console.ReadLine()!);

            fgts = (salario / 100) * 8;

            Console.WriteLine($"Salário (R$)..: {salario}");
            Console.WriteLine($"FGTS: {fgts}");
        }
    }
}