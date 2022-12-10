using System;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000 - DONE!

        public static void Print1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time - DONE!

        public static void Threes()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not - DONE!

        public static void EqualOrNot()
        {
            Console.WriteLine("Pick a number");
            int firstChoice = int.Parse(Console.ReadLine());

            Console.WriteLine("Pick another number, and I will tell you if they are equal or not.");
            int secondChoice = int.Parse(Console.ReadLine());

            if (firstChoice == secondChoice)
            {
                Console.WriteLine($"You selected {firstChoice} and {secondChoice}, and they ARE equal.");
            }
            else
            {
                Console.WriteLine($"You selected {firstChoice} and {secondChoice}, and they ARE NOT equal.");
            }
        }

        //Write a method to check whether a given number is even or odd - DONE!

        public static void EvenOrOdd()
        {
            Console.WriteLine("Ready to pick some more numbers? Go ahead and pick another one, and I will tell you if it is even or odd.");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even.");
            }
            else
            {
                Console.WriteLine($"{num} is odd.");
            }
        }

        //Write a method to check whether a given number is positive or negative - DONE!

        public static void IsPositive()
        {
            Console.WriteLine("Tired yet? Not me! Pick another number, and this time I will tell you if it is positive or negative.");
            int posOrNeg = int.Parse(Console.ReadLine());

            if (posOrNeg >= 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote. - DONE!
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()


        public static void VoterEligible()
        {
            Console.WriteLine("Now that I have your attention, how old are you?");
            var VoterAge = int.Parse(Console.ReadLine());

            if (VoterAge >= 21)
            {
                Console.WriteLine($"You are {VoterAge}, and you are old enough to vote. Yay!");
            }
            else
            {
                Console.WriteLine($"You are {VoterAge}, and you are NOT old enough to vote. I am sorry!");
            }    
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10 - DONE!

        public static void NumberRange()
        {
            Console.WriteLine("Now I bet I can tell you if a number is between -10 and 10! Go ahead and try me. Give me another number.");
            var numForRange = int.Parse(Console.ReadLine());

            if (numForRange >= -10 && numForRange <= 10)
            {
                Console.WriteLine($"You selected {numForRange}, and it is within the range.");
            }
            else
            {
                Console.WriteLine($"You selected {numForRange}, and it is outside of the range.");
            }

        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer - DONE!

        public static void Multiplication()
        {
            Console.WriteLine("Ok before you go, let me show you my math skills. I can multiply any number by 1 through 12 and give you the results. Try me. Last number I swear.");
            var ChosenMultiple = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(ChosenMultiple * i);
            }
        }


        //Call the methods to test them in the Main method below


        static void Main(string[] args)
            {
                Print1000();

                Threes();

                EqualOrNot();

                EvenOrOdd();

                IsPositive();

                VoterEligible();

                NumberRange();

                Multiplication();

            }
        }
    }
