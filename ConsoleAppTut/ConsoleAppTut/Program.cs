using System;
using System.Threading;

namespace ConsoleAppTut
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Basic print out function.
            // Console.WriteLine("Hello World!");
            // Console.ReadLine(); // This stops the console from closing after excuting the print out function.

            // 2. Draw a shape using ThreadExceptionEventArgs console out function
            // Console.WriteLine("   /|");
            // Console.WriteLine("  / |");
            // Console.WriteLine(" /  |");
            // Console.WriteLine("/___|");
            // Console.ReadLine();

            // 3. Variables
            string playerName = "Rehan";
            int playerAge = 30;

            Console.WriteLine("There once was a man named " + playerName + ".");
            Console.WriteLine("He was " + playerAge + " years old.");
            Console.WriteLine("He really liked the name " + playerName + ".");
            Console.WriteLine("But didn't like being " + playerAge + ".");
            Console.ReadLine();
        }
    }
}
