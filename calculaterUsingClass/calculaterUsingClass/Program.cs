using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculaterUsingClass
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result=0;
            string operate;
            Console.Write("Enter the first value: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Secound value: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            there:
            Console.Write("Enter the Operator:(+ - * /) ");
            operate = Console.ReadLine();
            if (operate == "+") 
            {
                result=calculaterUsingClass.calculator.add(num1,num2);
                Console.WriteLine("the  add result is :{0}", result);
                //Console.WriteLine($"{num1}+{num2} is = {result}");
            }
            else if (operate == "-")
            {
                result =calculaterUsingClass.calculator.sub(num1, num2);
                Console.WriteLine("the sub result is :{0}", result);
            }
            else if (operate == "*")
            {
                result =calculaterUsingClass.calculator.mul(num1, num2);
                Console.WriteLine("the mul result is :{0}", result);
            }
            else if (operate == "/")
            {
                result =calculaterUsingClass.calculator.div(num1, num2);
                Console.WriteLine("the div result is :{0}", result);
            }
            else
            {
                Console.WriteLine("you chose the wrong operator , chose from listed...");
                goto there;
            }
            Console.ReadKey();
        }
    }
}
