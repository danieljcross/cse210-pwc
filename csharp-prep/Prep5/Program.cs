using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));
    
        static void DisplayWelcome(){
            Console.WriteLine($"Welcome to the program!");
        }
        static string PromptUserName(){
            Console.WriteLine("What is your name?");
            return Console.ReadLine();
        }
        static int PromptUserNumber(){
            Console.WriteLine("What is your favorite number?");
            return int.Parse(Console.ReadLine());
        }
        static int SquareNumber(int number){
            return number * number;
        }
        static void DisplayResult(string name, int number){
            Console.WriteLine($"Hello {name}, the square of your number is {number}.");
        }
    }
}