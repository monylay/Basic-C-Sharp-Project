using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program"); //intro
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?"); //ask for hour rate
            decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine()); //convert to decimal
            Console.WriteLine("Hours Worked Per Week?"); //ask for hours worked
            decimal hoursWorked1 = Convert.ToDecimal(Console.ReadLine()); //convert to decimal
            decimal weeklyPay1 = hourlyRate1 * hoursWorked1; //calculate weekly pay
            decimal annualSalary1 = weeklyPay1 * 52; //calculate annual salary

            Console.WriteLine("Person 2"); 
            Console.WriteLine("Hourly Rate?"); //ask for hour rate
            decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine()); //convert to decimal
            Console.WriteLine("Hours Worked Per Week?"); //ask for hours worked
            decimal hoursWorked2 = Convert.ToDecimal(Console.ReadLine()); //convert to decimal
            decimal weeklyPay2 = hourlyRate2 * hoursWorked2; //calculate weekly pay
            decimal annualSalary2 = weeklyPay2 * 52; //calculate annual salary

            Console.WriteLine("Annual Salary of Person 1: " + annualSalary1);
            Console.WriteLine("Annual Salary of Person 2: " + annualSalary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool comparison = annualSalary1 > annualSalary2;
            Console.WriteLine(comparison);
        }
    }
}
