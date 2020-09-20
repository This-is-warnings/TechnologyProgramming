using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Какую функцию вы хотите использовать? \n" +
                    "1 - sh(x)\n2 - x^2\n3 - e^x");
                // int Choise = int.Parse(Console.ReadLine());
                string choise = Console.ReadLine();
                if (prov(choise))
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Введите последовательно x, y и z");
                            double x = Convert.ToDouble(Console.ReadLine());
                            double y = Convert.ToDouble(Console.ReadLine());
                            double z = Convert.ToDouble(Console.ReadLine());
                            if (provDel(x, y, choise))
                            {
                                Console.WriteLine($"Результат: {F(x, y, z, choise)}");
                                break;
                            }
                            else Console.WriteLine("Получается деление на ноль. Введите другие значения");

                        }
                        catch
                        {
                            Console.WriteLine("Что-то пошло не по плану :(\n" +
                                               "Попробуйте заново!");
                        }
                    }
                }
                else Console.WriteLine("Неверное значение, попробуйте снова");

               
            }
        }
        static bool prov(string ch)
        {
            if (ch == "1" || ch == "2" || ch == "3") return true;
            else return false;
        }
        static double Sh(double x)
        {
            return (Math.Exp(x) - Math.Exp(-x))/2;
        }
        static double F(double x, double y, double z,string ch)
        {
            double min=0, max=0;
            switch (ch)
            {
                case "1":
                    {
                        if ((Sh(x) + y) > (y - z)) min = y - z;
                        else min = Sh(x) + y;
                        if (Sh(x) > y) max = Sh(x);
                        else max = y;
                        break;
                    }
                case "2":
                    {
                        if ((x*x + y) > (y - z)) min = y - z;
                        else min = x*x + y;
                        if (x*x > y) max = x*x;
                        else max = y;
                        break;
                    }
                case "3":
                    {
                        if ((Math.Exp(x) + y) > (y - z)) min = y - z;
                        else min = Math.Exp(x) + y;
                        if (Math.Exp(x) > y) max = Math.Exp(x);
                        else max = y;
                        break;
                    }
            }
            return min / max;
            
        }
        static bool provDel(double x,double y,string ch)
        {
            double res = 0;
            switch (ch)
            {
                case "1":
                    {
                        
                        if (Sh(x) > y) res = Sh(x);
                        else res = y;
                        break;
                    }
                case "2":
                    {
                   
                        if (x * x > y) res = x * x;
                        else res = y;
                        break;
                    }
                case "3":
                    {
                        
                        if (Math.Exp(x) > y) res = Math.Exp(x);
                        else res = y;
                        break;
                    }
            }
            if (res == 0) return false;
            else return true;
        }
    }
}
