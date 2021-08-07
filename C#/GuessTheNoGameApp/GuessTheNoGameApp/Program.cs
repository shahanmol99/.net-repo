using System;

namespace GuessTheNoGameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char playAgainFlag = 'y';
            int randomNo, guess, count;

            while(playAgainFlag!='n')
            {
                Console.WriteLine("Guess The Number Game");
                Console.WriteLine("I am Thinking of a Number from 1 to 10....");
                count = 1;

                Random random = new Random();
                randomNo = random.Next(1, 10);

                while(true)
                {
                    Console.WriteLine("Your guess: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    count = count + 1;

                    if(guess<randomNo)
                    {
                        Console.WriteLine("Too Low");
                        continue;
                    }

                    if(guess>randomNo)
                    {
                        Console.WriteLine("Too High");
                        continue;
                    }

                    Console.WriteLine("You guessed it in " + count + " tries");
                    break;
                }
                Console.WriteLine("Would you like to play again ? (y / n) : ");
                playAgainFlag = Console.ReadKey().KeyChar;
            }

            Console.WriteLine("Thankyou For Playing");
            Console.ReadLine();
        }
    }
}
