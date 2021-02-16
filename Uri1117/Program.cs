using System;
using System.Globalization;
namespace Uri1117
{
    class Program
    {
        static void Main(string[] args)
        {
            

            double a, b, media;


            


           
               
                a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                while (a < 0 || a > 10)
                {
                    Console.WriteLine("Nota inválida");

                    a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                }

                b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                while (b < 0 || b > 10)
                {
                    Console.WriteLine("Nota inválida");

                    b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                }

                media = (a + b) / 2.0;

                Console.WriteLine("Média = " + media.ToString("F2", CultureInfo.InvariantCulture));
              
            }
        }
    }

