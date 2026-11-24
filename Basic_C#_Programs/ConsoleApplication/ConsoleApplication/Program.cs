using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = number * 50; //take user input and multiply it by 50
            Console.WriteLine(result);

            Console.WriteLine("Enter a number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int result2 = number2 + 25; //take user input and add 25 to it
            Console.WriteLine(result2);


            Console.WriteLine("Enter a number: ");
            double number3 = Convert.ToDouble(Console.ReadLine());
            double quotient = number3 / 12.5; //take user input and divide it
            Console.WriteLine(quotient);

            Console.WriteLine("Enter a number: ");
            int number4 = Convert.ToInt32(Console.ReadLine());
            bool result3 = number4 > 50; // take user input and check if its greater than 50
            Console.WriteLine(result3);

            Console.WriteLine("Enter a number: ");
            int remainder = Convert.ToInt32(Console.ReadLine());
            int result4 = remainder % 7; //take user input and get the remainder
            Console.WriteLine(result4);
            Console.ReadLine();



        }
    }
}
