using System;
using System.Globalization;

namespace EntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] v = Console.ReadLine().Split(' ');
            string[] v1 = s.Split(' ');
            string a = v1[0];
            string b = v1[1];
            string c = v1[2];
            string d = v[0];
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
