using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Game
    {
        static void Main(string[] args)
        {
            RunGame();
            Console.ReadKey();
        }
        static void RunGame()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 10000);
            int NumTries = 0;
            int? NumGuessed= null;
            int newNumber=0;

            do
            {
                Console.WriteLine("---Guess the secret number--- \n \n Write a number:");
                newNumber = int.Parse(Console.ReadLine());

                //assigns the first value if numguessed is null
                if (NumGuessed == null)
                {
                    NumGuessed = newNumber;
                    NumTries++;
                }
                else
                {
                    //if it is not null then asks if is the same number or not
                    if(NumGuessed != newNumber)
                    {
                        NumTries++;
                        NumGuessed = newNumber;
                    }
                }

                //validation to see if the number is bigger
                if (NumGuessed > randomNumber)
                {
                    Console.WriteLine("Too large");
                }
                if (NumGuessed < randomNumber)
                {
                    Console.WriteLine("To small");
                }

            } while (NumGuessed != randomNumber);

            Console.WriteLine("---End of the game--- \n \n The secret number was: " + randomNumber + "\n Number of attempts: " + NumTries);
        }

    }
}
