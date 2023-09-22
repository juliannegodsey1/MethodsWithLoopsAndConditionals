using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintThousand();
            Threes();
            IsEqual(2, 8);
            IsNumEven(9);
            PosOrNeg(-10);
            IsOldEnough();
            Range();

        




        }

        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void Threes()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }

        }

        public static bool IsEqual(int a, int b)
        {
            var check = (a == b) ? true : false;
            return check;
        }


        public static bool IsNumEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static string PosOrNeg(int num2)
        {
            var poscheck = (num2 > 0) ? "positive" : "negative";
            return poscheck;
        }


        public static void IsOldEnough()
        {
            Console.WriteLine("How old are you?");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput >= 18)
            {
                Console.WriteLine("You can vote!");
            }
            else
            {
                Console.WriteLine("Sorry, you can't vote yet!");
            }

        }


        public static bool Range()
        {
            int numGiven = int.Parse(Console.ReadLine());

            var inRange = (numGiven <= 10 && numGiven >= -10) ? true : false;
            return inRange;
        }
        

    }
}
