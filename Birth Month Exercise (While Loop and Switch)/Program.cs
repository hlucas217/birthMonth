using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birth_Month_Exercise__While_Loop_and_Switch_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the month you were born.");
            //string month = Console.ReadLine().ToLower();

            //if (month == "december" || month == "january" || month == "february")
            //{
            //    Console.WriteLine("You were born in the Winter.");
            //}

            //else if (month == "march" || month == "april" || month == "may")
            //{
            //    Console.WriteLine("You were born in the Spring.");
            //}

            //else if (month == "june" || month == "july" || month == "august")
            //{
            //    Console.WriteLine("You were born in the Summer.");
            //}

            //else
            //{
            //    Console.WriteLine("You were born in the Fall.");
            //}


            var questionLoop = true;
            var i = 1;
            while (questionLoop)
            {
                i = i + 1;

                string month;
                Console.WriteLine("What month were you born?");
                month = Console.ReadLine().ToLower();

                switch (month)
                {
                    case "december":
                    case "january":
                    case "february":
                        Console.WriteLine("You were born in the winter.");
                        Console.WriteLine("I will repeat until you type: stop");
                        Console.WriteLine("");
                        break;
                    case "march":
                    case "april":
                    case "may":
                        Console.WriteLine("You were born in the spring.");
                        Console.WriteLine("I will repeat until you type: stop");
                        Console.WriteLine("");
                        break;
                    case "june":
                    case "july":
                    case "august":
                        Console.WriteLine("You were born in the summer.");
                        Console.WriteLine("I will repeat until you type: stop");
                        Console.WriteLine("");
                        break;
                    case "stop":
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("You were born in the autumn.");
                        Console.WriteLine("I will repeat until you type: stop");
                        Console.WriteLine("");
                        break;
                }

                if (month == "stop")
                {
                    questionLoop = false;
                }
            }
            Console.ReadLine();
        }
    }
}
