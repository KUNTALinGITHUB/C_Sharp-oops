using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base value: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the power value: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = Math.Pow(num1, num2);
            Console.WriteLine("{0} to the power {1} is : {2}",num1,num2,result);

            Console.WriteLine("Enter the first value: ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the secound value: ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            a2 = Math.Pow(num1, 2);
            b2 = Math.Pow(num2, 2);
            double c = Math.Sqrt(a2 + b2);
            Console.WriteLine(" the sqrt  add of {0} and {1} is : {2}",a2,b2,c);
            Console.ReadKey();
            

        }
    }
}
