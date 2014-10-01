using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace n2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите степень многочлена = ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Введите X = ");
            int X = int.Parse(Console.ReadLine());
            Polynom _polynom = new Polynom(X,N);
            _polynom.SetFactors();
            Console.WriteLine("P({2}) = {0} = {1}", _polynom.exp, _polynom.GetSum(),X);
            Console.WriteLine("\nНажмите на любую клавишу для выхода");
            Console.ReadKey();

        }
    }
}
