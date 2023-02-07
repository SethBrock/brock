using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hang_Man
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Hangman! \nPress any button to begin!");
            Console.ReadKey();

            while (true)
            {

                bool result = PlayGame();
                if (!result)
                {

                    break;

                }

            }
            
        }

        public static bool PlayGame()
        {

            bool continueGame = true;
            bool isPlaying = true;
            int tries = 6;

            string[] listwords = new string[10]
            {
                "cow",
                "goat",
                "computer",
                "mexico",
                "melon",
                "candy",
                "jasmine",
                "apple",
                "orange",
                "mango"
            };

            Random randGen = new Random();

            var idx = randGen.Next(0, 9);

            string mysteryWord = listwords[idx];

            char[] guess = new char[mysteryWord.Length];

            Console.WriteLine("Please enter your guess: ");

            for (int p = 0; p < mysteryWord.Length; p++)
            {
                
                guess[p] = '*';

            }

            while (isPlaying)
            {
                
                char playerGuess = char.Parse(Console.ReadLine());

                for (int j = 0; j < mysteryWord.Length; j++)
                {

                    if (playerGuess == mysteryWord[j])
                    {

                        guess[j] = playerGuess;

                    }
                        
                }

                if (!mysteryWord.Contains(playerGuess))
                {

                    tries--;
                    Console.WriteLine("Oops that's not in this word! \nYou have " + tries + " tries left!");

                }

                Console.WriteLine(guess);

                if (!guess.Contains('*'))
                {

                    Console.WriteLine("Congratulations! You guessed the word!");

                    isPlaying = false;

                }
                else if(tries <= 0)
                {

                    Console.WriteLine("You ran out of tries! The word was " + mysteryWord + "!");

                    isPlaying = false;

                }               

            }

            Console.WriteLine("Press 'Enter' once to play again! \nPress 'Escape' twice to exit!");
            //int menuContinue = Convert.ToInt32(Console.ReadLine());

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {

                continueGame = true;

            }
            else if(Console.ReadKey().Key == ConsoleKey.Escape)
            {

                continueGame = false;

            }

            return continueGame;

        }

    }

}
