using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy"); //display company name
            Console.WriteLine("Student Daily Report"); //report title
            Console.WriteLine("What is your name?"); //ask for user name
            string yourName = Console.ReadLine(); //store user name in variable
            Console.WriteLine("Hello " + yourName); //display user name
            Console.WriteLine("What course are you on?"); //ask for course name
            string courseName = Console.ReadLine(); //store course name in variable
            Console.WriteLine("You are on the " + courseName + " course."); //display course name
            Console.WriteLine("What page number are you on?"); //ask for page number
            string pageNumber = Console.ReadLine(); //store page number in variable
            int pageNum = Convert.ToInt32(pageNumber); //convert page number to integer
            Console.WriteLine("You are on page " + pageNum); //display page number
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"."); //ask if help is needed
            string helpNeeded = Console.ReadLine(); //store help response in variable
            bool help = Convert.ToBoolean(helpNeeded); //convert help response to boolean
            Console.WriteLine("You need help: " + help); //display help response
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics."); //ask for positive experiences
            string positiveExperiences = Console.ReadLine(); //store positive experiences in variable
            Console.WriteLine("Positive experiences: " + positiveExperiences);
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific."); //ask for other feedback
            string otherFeedback = Console.ReadLine(); //store other feedback in variable
            Console.WriteLine("Other feedback: " + otherFeedback);
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine(); //store study hours in variable
            Console.WriteLine("You studied for " + studyHours + " hours today.");
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day! This is the end of the program."); //display thank you message
            Console.ReadLine();
        }
    }
}
