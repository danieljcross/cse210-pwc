using System;
using System.ComponentModel.Design;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        int total = 0;
        int largest = 0;
        Console.WriteLine("Enter a list of positive numbers, then type 0 when finished.");
        List<int> numbers = new List<int>();
        while (true){
            int number = int.Parse(Console.ReadLine());
            if (number == 0){
                break;
            }
            else{numbers.Add(number);
            }
        }
        foreach (int number in numbers){
            sum += number;
            total ++;
            if (number > largest){
                largest = number;
            }
        }
        Console.WriteLine($"The sum is: {sum}\nThe average is {Math.Round((double)sum / total, 2)}\nThe largest is: {largest}.");
    }
}