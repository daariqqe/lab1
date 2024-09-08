using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            string name = "Молдован Дар'я";
            int age = 17;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Завдання 1");
            Console.WriteLine("Мене звати {0}, мені років {1}", name, age);
            Console.WriteLine();

            //task 2 
            int a = 3;
            int b = 4;
            double c;

            c = (Math.Pow(a + b, 3) - Math.Pow(a, 3f)) / ((3 * a * Math.Pow(b, 2)) + Math.Pow(b, 3) + (3 * Math.Pow(a, 2) * b));
            Console.WriteLine("Завдання 2");
            Console.WriteLine($"{c}");
            Console.WriteLine();

            //task  3
            Console.WriteLine("Завдання 3");
            Console.WriteLine("Введіть трицифрове число та натисніть Enter ");
            int last, mid, first, swap;
            int q = Convert.ToInt32(Console.ReadLine());
            last = q % 10;
            mid = (q / 10) % 10;
            first = q / 100;
            swap = last * 100 + mid * 10 + first;
            Console.WriteLine(swap);
            Console.ReadKey();


        }
    }
}
