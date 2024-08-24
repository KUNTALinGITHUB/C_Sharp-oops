using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalORTernayOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENter a another number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            string massage= (num1 > num2) ? num1+"is bigger" : num2+"bigger ";
            Console.WriteLine(massage);
            Console.ReadKey();
        }
    }
}
