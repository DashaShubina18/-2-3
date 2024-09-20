using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лабораторна_2_завдання_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double x1, y1, x2, y2,x3,y3;
            Console.WriteLine("Input x1");
            x1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input y1");
            y1= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input x2");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input y2");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input x3");
            x3= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input y3");
            y3= Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Введіть назву відрізка(наприклад, 'AB', 'BC', 'AC', 'BA')");
            string name = Console.ReadLine(); //запам'ятовує відрізки з їх координатами

            double distance=0.0;

            switch(name)
            {
                case "AB":
                case "BA":
                    Console.WriteLine(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
                    distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                    break;
                case "AC":
                case "CA":
                    Console.WriteLine(Math.Sqrt(Math.Pow((x3-x1), 2) + Math.Pow((y3 - y1), 2)));
                    distance = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
                    break;
                case "BC":
                case "CB":
                    Console.WriteLine(Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2)));
                    distance = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
                    break;
                default:
                    Console.WriteLine("Невірна назва відрізка");
                    break;
            }
            Console.WriteLine($"Довжина відрізка {name}={distance}");
            Console.ReadKey();
            

        }
    }
}
