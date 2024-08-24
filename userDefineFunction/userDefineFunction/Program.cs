using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userDefineFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st value: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the 2nd value: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Double result = sum(num1, num2);
            Console.WriteLine("The resultent value: ");
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static double sum(double x, double y)
        {
            double add = x + y;
            return add;
        }
    }
}
