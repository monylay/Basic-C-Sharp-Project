using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine("Five plus Ten = " + total.ToString());
            //Console.WriteLine(combined);
            //Console.ReadLine();


            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 10 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 > 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            int roomTemperature = 70;
            int currentTemperature = 72;
            bool isWarm = currentTemperature > roomTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();

            int roomTemperature2 = 70;
            int currentTemperature2 = 70;
            bool isWarm2 = currentTemperature2 >= roomTemperature2;
            //bool isWarm2 = CurrentTemperature2 == roomTemperature2; checks for equality '=='
            //bool isWarm2 = CurrentTemperature2 != roomTemperature2; checks for inequality '!='

            Console.WriteLine(isWarm2);
            Console.ReadLine();

        }
    }
}
