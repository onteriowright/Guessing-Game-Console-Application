using System;

namespace Guessing_Game
{
  class Program
  {
    static void Main(string[] args)
    {
      Random rand = new Random();
      int secretNumber = rand.Next(1, 11);

      for (int i = 0; i < 3; i++)
      {

        Console.WriteLine("Guess a number between 1 and 10");
        string userGuesses = Console.ReadLine();
        int userGuessesInt = int.Parse(userGuesses);

        if (userGuessesInt == secretNumber && i != 3)
        {
          Console.WriteLine($"You guessed it! It was {secretNumber}!");
          return;


        }
        else if (userGuessesInt < secretNumber && i != 2)
        {
          Console.WriteLine("Nope that wasn't it. Guess Higher!");
        }
        else if (userGuessesInt > secretNumber && i != 2)
        {
          Console.WriteLine("Nope that wasn't it. Guess Lower!");
        }
        else if (i == 2 && userGuessesInt != secretNumber)
        {
          Console.WriteLine($"Game Over! Number was {secretNumber}!");
          return;
        }

      }


    }
  }
}
