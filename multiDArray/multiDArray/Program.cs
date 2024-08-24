using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiDArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentName1 = {"Kuntal","Keka","Kunal"};
            string[] studentName2 = {"Rohit","Bristi","Barsha"};
            string[] studentName3 = {"Riya","Shreya","Manan"};

            string[,] class1 ={
                               {"Kuntal","Keka","Kunal"},
                               {"Rohit","Bristi","Barsha"},
                               {"Riya","Shreya","Manan"}
                              };
           /* foreach (string student in class1)
            {
                  Console.WriteLine(student);          
            }*/
            class1[1, 2] = "Manu";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++) {
                    Console.Write(class1[i,j]+"    ");
                }
                Console.WriteLine();
            }
                Console.ReadKey();
        }
    }
}
