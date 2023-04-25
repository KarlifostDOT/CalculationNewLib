using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationLib2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = CalculationLib1.CalculationLib.Plus(2,4);
            Console.WriteLine(result);
            Console.ReadLine();

            double result1 = CalculationLib1.CalculationLib.Minus(2, 4);
            Console.WriteLine(result1);
            Console.ReadLine();

            double result2 = CalculationLib1.CalculationLib.Divide(2, 4);
            Console.WriteLine(result2);
            Console.ReadLine();

            double result3 = CalculationLib1.CalculationLib.Multiply(2, 4);
            Console.WriteLine(result3);
            Console.ReadLine();
        }
    }
}
