using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment188
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Guess the player's number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 2;

            while (isGuessed)
            {
                switch (number)
                {

                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess the player's number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You guessed 7. Try again.");
                        Console.WriteLine("Guess the player's number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 13:
                        Console.WriteLine("You guessed 13. Try again.");
                        Console.WriteLine("Guess the player's number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed 12. Try again.");
                        Console.WriteLine("Guess the player's number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You guessed 2. That is correct!");
                        isGuessed = false;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess the player's number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            



            Console.WriteLine("Guess the player's number?");
            int number2 = Convert.ToInt32(Console.ReadLine());
            bool isGuessed2 = number2 == 2;

            do
            {
                switch (number2)
                {

                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess the player's number?");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You guessed 7. Try again.");
                        Console.WriteLine("Guess the player's number?");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 13:
                        Console.WriteLine("You guessed 13. Try again.");
                        Console.WriteLine("Guess the player's number?");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed 12. Try again.");
                        Console.WriteLine("Guess the player's number?");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You guessed 2. That is correct!");
                        isGuessed2 = false; 
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess the player's number?");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (isGuessed2);
            Console.Read();
        }
    }
}