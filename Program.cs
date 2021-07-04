using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            var num = random.Next(0, 100);

            bool win = false;

            do
            {
                Console.WriteLine("Guess a number between 0 and 100");
                string input = Console.ReadLine();
                var i = int.Parse(input);

                if (i > num)
                {
                    Console.WriteLine("Number is too high, try again");
                }
                if (i < num)
                {
                    Console.WriteLine("Number is too low, try again");
                }

                if (i == num)
                {
                    Console.WriteLine("You win!");
                    win = true;
                }
            }
            while (win == false);
        }
    }
}
