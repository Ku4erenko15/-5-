using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace практическая_5_кучеренко
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("b = ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("c = ");
                int c = int.Parse(Console.ReadLine());
                double d = Math.Pow(b, 2) - 4 * a * c;
                if (d > 0)
                {
                    Console.WriteLine("2 корня");
                    double x1 = (-b+Math.Sqrt(d))/(2*a);
                    double x2 = (-b-Math.Sqrt(d))/(2*a);
                    Console.WriteLine($"x1={x1:f2}\tx2={x2:F2}");
                }
                else if (d == 0)
                {
                    Console.WriteLine("1 корень");
                    double x = -b / 2 * a;
                    Console.WriteLine($"x1={x:f2}");
                }
                else
                {
                    Console.WriteLine("Нет решений");
                }
                Console.ReadKey();
            }
            
            catch (Exception ex)
{
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
        }
    }
}
