using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {

            string guess = "";
            string word = "";

            string[] wordBank = new string[5]
            {

                "pig",
                "cow",
                "zebra",
                "horse",
                "duck"
                //avoid words that repeat a letter
                //there I did, happy?
            };
            
            Console.WriteLine("Welcome to Hang The Man!");
            Console.WriteLine("Press 'Enter' to begin!");

            if(Console.ReadKey().Key != ConsoleKey.Enter)
            {



            }
            else
            {

                while (PlayGame(guess, word, wordBank) == true)
                {

                    PlayGame(guess, word, wordBank);

                }

            }

        }

        static bool PlayGame(string guess, string word, string[] words)
        {

            bool isPlaying = true;
            
            int wordIndex = PickWord();
            Console.WriteLine(wordIndex);

            string chosenWord = words[wordIndex];
            Console.WriteLine(chosenWord);

            int lettersInWord = 0;
            int tries = 5;

            PrintLines(word);

            Console.WriteLine("Press any letter to guess!");
            guess = Console.ReadLine();
            
            if(guess == "*")
            {

                //do something here or something idk
                lettersInWord--;

            }
            else
            {

                tries--;
                Console.WriteLine("Oops! That's not a letter in this word!");
                Console.WriteLine("You have " + tries + " failed attempts left until you lose!");

                if(tries == 0)
                {

                    isPlaying = false;

                }

            }

            return isPlaying;

        }

        /*private static int PrintLetters(List<char> guessedLetters, string randomWord)
        {

            int counter = 0;
            int rightLetters = 0;

            Console.WriteLine("\r\n");
            //this is gonna do something I think
            foreach (char c in randomWord)
            {

                if (guessedLetters.Contains(c))
                {

                    Console.Write(c + " ");

                }
                else
                {

                    Console.Write(" ");

                }

                counter++;

            }

            return rightLetters;

        }*/

        private static void PrintLines(string randomWord)
        {

            Console.Write("");



            foreach (char c in randomWord)
            {

                Console.OutputEncoding = System.Text.Encoding.Unicode;

                Console.Write("\u0305");
                //idk what this means

            }

        }
        private static int PickWord()
        {

            Random index = new Random();

            int num = index.Next(6);
            

            return num;

        }

    }

    class Person
    {

        public string name;
        public float speed;
        public bool alive;

        private int age;
        private char middleInitial;

        Person()
        {

            name = "";
            speed = 1.0f;
            alive = true;

        }

        Person (string nameParameter, float speedParameter, bool aliveParameter)
        {

            name = nameParameter;
            speed = speedParameter;
            alive = aliveParameter;

        }

        void SetAge(int age)
        {

            age = age;

        }

        int GetAge()
        {

            age = 9;

            return 99;

        }

        string SayAge()
        {

            return "I am " + age + " years old.";

        }

    }
}
