using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 03";

            int num, c = 1, p = 2, d = 2;

            Console.Write("Ingrese numero: ");
            num = int.Parse(Console.ReadLine());
            //num = Convert.ToInt32(Console.ReadLine());

            while (c <= num)
            {
                if (p % d == 0)
                {
                    if (p == d)
                    {
                        Console.Write(p + ", ");
                        c++;
                    }
                    d = 2;
                    p++;
                }
                else 
                {
                    d++;
                }
            }

            Console.ReadKey();
        }
    }
}
