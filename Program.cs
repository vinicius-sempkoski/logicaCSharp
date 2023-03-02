using System;

namespace Exercicio2For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, c = 0, f = 0, num1;
            Console.WriteLine("Digite um numero inteiro:");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                num1 = int.Parse(Console.ReadLine());
                if (num1 >= 10 && num1 <= 20)
                {
                    f++;
                }
                else
                {
                    c++;
                }
            }
            Console.WriteLine($"\n{f} in\n{c} out");
        }
    }
}
