using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab1_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите последовательно x, y и z");
                    double x = Convert.ToDouble(Console.ReadLine());
                    double y = Convert.ToDouble(Console.ReadLine());
                    double z = Convert.ToDouble(Console.ReadLine());

                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                    Console.WriteLine($"Значение функции:  {function(x, y, z)}");
                }
                catch
                {
                    Console.WriteLine("Вы что-то сделали неправильно!");
                }
            }
        }
        static double function(double x, double y, double z)
        {

            return Math.Pow(2,Math.Pow(y,x)) + Math.Pow(3,y*x) - (y*(Math.Atan(z)-Math.PI/6))/(Math.Abs(x) + (1/(y*y+1)));
        }
    }
}
