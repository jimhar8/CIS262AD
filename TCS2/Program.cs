using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2
{
    class Program
    {
        static void Main(string[] args)
        {
            int intNumber1;
            int intNumber2;
            int intSum;

            Console.WriteLine("CS2 Jim Harris \n");

            Console.Write("Enter first integer: "); //prompt
            intNumber1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: "); //prompt
            intNumber2 = Convert.ToInt32(Console.ReadLine());

            intSum = intNumber1 + intNumber2;

            Console.WriteLine("\n Sum is {0}", intSum);

        }  //end Main
    }
}
