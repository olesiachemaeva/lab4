using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = Convert.ToDouble(Console.ReadLine());

            double maxnumber = 2 * N - 1;
            double number = 2;
            double answer = 0;
            for (int i = 0; i < maxnumber / 2; i++)
            {
                if (maxnumber > number)
                {
                    answer += maxnumber - number;
                    number += 2;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Квадрат числа N = " + Math.Sqrt(answer));
                Console.ReadLine();
            
        }
    }
}
