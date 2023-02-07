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

            string word = "";

            string[] wordBank = new string[5]
            {

                "method",
                "goat",
                "zebra",
                "pig",
                "cow"
                //avoid words that repeat a letter
            };
            
            Console.WriteLine("Welcome to Hang The Man!");
            Console.WriteLine("Press 'Enter' to begin!");

            if(Console.ReadKey().Key != ConsoleKey.Enter)
            {



            }
            else
            {

                while (true)
                {

                    PlayGame(word, wordBank);

                }

                

            }

        }

        static bool PlayGame(string word, string[] words)
        {
            int wordIndex = PickWord();
            //Console.WriteLine(wordIndex);

            int tries = 5;
            int lettersLeft = 0;
            bool isPlaying = true;

            string chosenWord = words[wordIndex];
            //Console.WriteLine(chosenWord);

            GetNumberOfLetters(lettersLeft);

            /*PrintLines(word);*/

            Console.WriteLine("Press any letter to guess!");
            char guess = char.Parse(Console.ReadLine());
            //console closes after this, idk why

            for(int i = 0; i < chosenWord.Length; i--)
            {



            }

            if(true)
            {
                
                lettersLeft--;
                
                Console.WriteLine("That letter is in this word!");
                Console.WriteLine("There are " + lettersLeft + " letters left in this word!");

            }
            else
            {

                tries--;
                
                Console.WriteLine("Oops! That letter is not in this word!");
                Console.WriteLine("You have " + tries + " failed attempts left until you lose!");

                if(tries <= 0)
                {

                    isPlaying = false;

                }

            }

            return isPlaying;

        }

        private static int GetNumberOfLetters(int index)
        {

            int number = 0;

            if(index == 0)
            {

                number = 6;

            }
            else if (index == 1)
            {

                number = 4;

            }
            else if (index == 2 || index == 3)
            {

                number = 3;

            }
            else if (index == 4)
            {

                number = 5;

            }

            return number;

        }

        private static void GetCorrectLetters(int index, char guess)
        {
            //this is to get correct guesses I think??
            //idk I kinda lost the plot and am making a lot of methods
            if(index == 0)
            {

                string[] wordMethod = new string[6]
                {
                    "m",
                    "e",
                    "t",
                    "h",
                    "o",
                    "d"
                };

            }
            else if(index == 1)
            {

                string[] wordGoat = new string[4]
                {
                    "g",
                    "o",
                    "a",
                    "t"
                };

            }
            else if(index == 2)
            {

                string[] wordPig = new string[3]
                {
                    "p",
                    "i",
                    "g"
                };

            }
            else if(index == 3)
            {

                string[] wordCow = new string[3]
                {
                    "c",
                    "o",
                    "w"
                };

            }
            else if(index == 4)
            {

                string[] wordZebra = new string[5]
                {
                    "z",
                    "e",
                    "b",
                    "r",
                    "a"
                };

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
