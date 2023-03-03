using System;

namespace Exercicio1EstruturaCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Digite um numero para verificar se é negativo ou não");
            num = int.Parse(Console.ReadLine());

            if(num < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NAO NEGATIVO");
            }
        }
    }
}
