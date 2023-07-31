using System;
using System.Threading;

namespace ConsoleAppTut
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Basic print out function
            // Console.WriteLine("Hello World!");
            // Console.ReadLine(); // This stops the console from closing after excuting the print out function.

            // 2. Draw a shape using ThreadExceptionEventArgs console out function
            // Console.WriteLine("   /|");
            // Console.WriteLine("  / |");
            // Console.WriteLine(" /  |");
            // Console.WriteLine("/___|");
            // Console.ReadLine();

            // 3. Variables
            // string playerName = "Rehan";
            // int playerAge = 30;

            // Console.WriteLine("There once was a man named " + playerName + ".");
            // Console.WriteLine("He was " + playerAge + " years old.");
            // Console.WriteLine("He really liked the name " + playerName + ".");
            // Console.WriteLine("But didn't like being " + playerAge + ".");
            // Console.ReadLine();

            // 4. Datatypes
            // string statement = "\"This is a sentence.\"";
            // char classification = 'A';
            // int age = 21;
            // double gpa = 3.7;
            // bool isDead = false;

            // Console.WriteLine(
            //     "{\nstatement: " + statement +
            //     ",\nclassification: " + classification +
            //     ",\nage: " + age +
            //     ",\ngpa: " + gpa +
            //     ",\nisDead: " + isDead +
            //     "\n}"
            // );
            // Console.ReadLine();

            // 5. Gettings user inputs
            // Console.Write("Enter your name:\n");
            // string name = Console.ReadLine();

            // Console.WriteLine("\nHello " + name + "!");
            // Console.ReadLine();

            // 6. Guessing Game
            GuessGame();
        }

        static void GuessGame()
        {
            string secretWord = "game";
            string guess = "";
            int noOfGuesses = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (noOfGuesses != 0)
                {
                    Console.Write("Guess the word:\n");
                    guess = Console.ReadLine().ToString();
                    noOfGuesses--;
                    if (guess != secretWord) Console.WriteLine("Word is incorrect! Try again...\n");
                }
                else
                {
                    outOfGuesses = true;
                }
            }

            if (outOfGuesses)
            {
                Console.WriteLine("Out of guesses!");
            }
            else
            {
                Console.WriteLine("\nYou win!");
            }
        }
    }
}
