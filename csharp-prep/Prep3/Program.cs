using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 10);
        int guessCount = 1;

        Console.WriteLine("Welcome to Guess My Number!\n\nTry to guess our number between 1 and 10!\n");
        Console.WriteLine("Enter your first guess:");
        int guess = int.Parse(Console.ReadLine());

        while (guess != number){
            guessCount ++;
            Console.WriteLine($"Not quite! Our number is {(guess > number ? "lower" : "higher")} than that. Enter your next guess.");
            guess = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Correct! It {(guessCount < 4 ? "only" : "")} took you {guessCount} tr{(guessCount == 1 ? "y" : "ies")}!");
    }
}