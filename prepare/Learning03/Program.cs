using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Journal program!");
        int num = 0;
        int writeCount = 0;
        string toStore;
        List<string> prompts = new List<string>{"Prompt 1", "Prompt 2", "Prompt 3", "Prompt 4", "Prompt 5", "Prompt 6", "Prompt 7", "Prompt 8", "Prompt 9"};


        while (num != 5){
            Console.WriteLine("What would you like to do?\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            num = int.Parse(Console.ReadLine());
            if (num == 1){
                Console.WriteLine(prompts[writeCount]);
                toStore = Console.ReadLine();
                writeCount ++;
                num = 0;
            }
            else if (num == 2){
                num = 0;
            }
            else if (num == 3){
                num = 0;
            }
            else if (num == 4){
                num = 0;
            }
            else if (num == 5){
                break;
            }
            else{
                break;
            }
        }
    }
}