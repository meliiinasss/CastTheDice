using System;

namespace CastTheDice;

class Program
{
    static readonly Random random = new();
    static int dice1 = random.Next(1, 7);
    static int dice2 = random.Next(1, 7);
    static int game = 1;

    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("**********************************************'");
        Console.WriteLine("Välkommen till spelet Cast The Dice!");
        Console.WriteLine("För att avbryta spelet tryck på tangenten b.");
        Console.WriteLine("**********************************************'");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("**********************************************'");
        Console.WriteLine("Spelomgång: {0}", game);
        Console.WriteLine("**********************************************'");
        Console.ResetColor();
        Console.WriteLine("CastTheDice");

        while(true)
        {
            dice1 = random.Next(1, 7);
            dice2 = random.Next(1, 7);

            int sum = dice1 + dice2;

            Console.WriteLine($"Tärning 1: {dice1}");
            Console.WriteLine($"Tärning 2: {dice2}");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Summan blev: {sum}");
            Console.ResetColor();


            if(sum == 12)
            {
                Console.WriteLine("Grattis! Du har vunnit!");
            }
            else
            {
                Console.WriteLine("Tyvärr vann du inte denna gången");
            }
            Console.WriteLine("Vill du spela igen? Tryck a för att fortsätta eller b för att avsluta");
            var input = Console.ReadLine();

            if(input == "b")
            {
                break;
            }
            if(input == "a")
            {
                game++;
                Console.ForegroundColor=ConsoleColor.DarkMagenta;
                Console.WriteLine("Spelomgång: {0}", game);
                Console.ResetColor();

                continue;

            }     
                
            
        }
    }

}