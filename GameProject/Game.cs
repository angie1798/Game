﻿using System;
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
            int randomNumber = rnd.Next(0, 100);
            int NumTries = 0;
            int NumGuessed = 0;

            do
            {
                Console.WriteLine("---Guess the secret number--- \n \n Write a number:");
                NumGuessed = int.Parse(Console.ReadLine());

                //validation to see if the number is bigger
                if (NumGuessed > randomNumber)
                {
                    Console.WriteLine("Too large");
                }
                if (NumGuessed < randomNumber)
                {
                    Console.WriteLine("To small");
                }

                NumTries++;

            } while (NumGuessed != randomNumber);

            Console.WriteLine("---End of the game--- \n \n The secret number was: " + randomNumber + "\n Number of attempts: " + NumTries);
        }

    }
}
