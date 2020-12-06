using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk_1_Challenges_Newest
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Declare/initialize variables: 1.first name  2.last name  3.age
            string firstName = "Joshua";
            string lastName = "Wright";
            int age = 31;


            //2.Declare/initialize an array holding 4+ favorite book titles
            string[] favoriteBooks = { "Hannibal", "Crash", "Dune", "Blood Meridian", "The Pearl" };


            //3.Make a list to hold dates, including the current date + time
            List<DateTime> list = new List<DateTime>();
            list.Add(DateTime.Now);
            list.Add(new DateTime(1898, 6, 22));
            list.Add(new DateTime(1933, 7, 20));
            list.Add(new DateTime(1920, 10, 8));
            list.Add(new DateTime(1930, 11, 15));
            list.Add(new DateTime(1948, 8, 1));


            //4.Write to console, variable.age and the int 7, use operators discussed
            //a.sum
            int sumAgePlusSeven = age + 7;
            //b.diff
            int diffAgeMinusSeven = age - 7;
            //c.prod
            int prodAgeTimesSeven = age * 7;
            //d.quot
            int quotAgeDividedBySeven = age / 7;
            //e.modulus
            int modAgeModulusSeven = age % 7;

            Console.WriteLine($"{sumAgePlusSeven}\n",
                $"{diffAgeMinusSeven}\n",
                $"{prodAgeTimesSeven}\n",
                $"{quotAgeDividedBySeven}\n",
                $"{modAgeModulusSeven}\n");


            //5.Write collection of conditionals for hours sleep/night
            Console.WriteLine("How many hours do you normally sleep?");
            int userInput = int.Parse(Console.ReadLine());
            //a.if 10+ -- "Wow!  That's a lot of sleep!"
            if(userInput >= 10)
            {
                Console.WriteLine("Wow!  That's a lot of sleep!");
            }
            //b.if 8-10 -- "You should be pretty rested"
            else if(userInput >= 8 && userInput < 10)
            {
                Console.WriteLine("You should be pretty rested.");
            }
            //c.if 4-8 -- "Bummer"
            else if(userInput >= 4 && userInput < 8)
            {
                Console.WriteLine("That's a bummer.");
            }
            //d.if 0-4 --"Oh man, get some sleep!"
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }

            //6.Write switch case that evaluates how the user's day has been
            Console.WriteLine("Hey, how was your day? Pick one...\n" +
                "1. Great\n" +
                "2. Good\n" +
                "3. Okay\n" +
                "4. Bad\n" +
                "5. Terrible");
            string response = Console.ReadLine().ToLower();

            switch (response)
            {
                case "1":
                case "great":
                    Console.WriteLine("Nice!  Glad to hear it, bro!");
                    break;
                case "2":
                case "good":
                    Console.WriteLine("Good, great, grand, wonderful...");
                    break;
                case "3":
                case "okay":
                    Console.WriteLine("Just okay?  What's up, buttercup?");
                    break;
                case "4":
                case "bad":
                    Console.WriteLine("I'm sorry to hear that, brotherman.");
                    break;
                case "5":
                case "terrible":
                    Console.WriteLine("Alright, drama queen, what's wrong?");
                    break;
            }
        }
    }
}