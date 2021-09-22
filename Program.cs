using System;
using System.Collections.Generic;

namespace LA1200_2_TeixeiradaSilva
{
    class Program
    {
        static void Main(string[] args)
        {
            int isOne;
            int isntOne;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Geben Sie eine Zahl zwischen 1 und 100 ein, Sie haben nur 8 Versuche: ");
            var guessAsString = Console.ReadLine();
            int guess;
            bool parseSuccess = int.TryParse(guessAsString, out guess);
            int ranber = new Random().Next(1, 100);
            int allowedTries = 8;
            int numberOfTries = 0;
            numberOfTries++;
            Console.Write("Sie haben noch " + (allowedTries - numberOfTries) + " Versuche übrig. ");
            while (true)
            {
                if (parseSuccess)
                {
                    if (guess > 100 || guess < 1)
                    {
                        Console.Write(" Sind Sie dumm? Geben Sie eine Zahl zwischen 1 und 100 ein: ");
                        guessAsString = Console.ReadLine();
                        parseSuccess = int.TryParse(guessAsString, out guess);

                    }
                    if (guess == ranber)
                    {
                        numberOfTries++;
                        if (guess == 69)
                        {
                            Console.Write(" Nice, aber");
                        }
                        Console.WriteLine();
                    }
                    if (guess < ranber)
                    {
                        numberOfTries++;
                        Console.Write(" Sie haben zu klein geraten, versuchen Sie es nochmal: ");
                        if (allowedTries - numberOfTries != 1)
                        {
                            Console.WriteLine(" Sie haben noch " + (allowedTries - numberOfTries) + " Versuche übrig.");
                        }
                        if (allowedTries - numberOfTries == 1)
                        {
                            Console.WriteLine("Sie haben nur noch " + (allowedTries - numberOfTries) + " Versuch übrig. ");
                        }
                        if (guess == 69)
                        {
                            Console.Write(" Nice, aber");
                        }
                        guessAsString = Console.ReadLine();
                        parseSuccess = int.TryParse(guessAsString, out guess);
                    }
                    if (guess > ranber)
                    {
                        numberOfTries++;
                        if (guess == 69)
                        {
                            Console.Write(" Nice, aber");
                        }
                        Console.Write(" Sie haben zu gross geraten, versuchen Sie es nochmal: ");
                        guessAsString = Console.ReadLine();
                        parseSuccess = int.TryParse(guessAsString, out guess);
                        if (allowedTries - numberOfTries != 1)
                        {
                            Console.Write("Sie haben noch " + (allowedTries - numberOfTries) + " Versuche übrig. ");
                        }

                        if (allowedTries - numberOfTries == 1)
                        {
                            Console.Write("Sie haben nur noch " + (allowedTries - numberOfTries) + " Versuch übrig. ");
                        }
                    }
                    if (numberOfTries == allowedTries)
                    {
                        Console.Clear();
                        if (guess != ranber)
                        {
                            Console.WriteLine("Sie haben keine Versuche mehr, die Zahl war: " + ranber);
                            break;
                        }
                        if (guess == ranber)
                        {
                            if (guess == 69)
                            {
                                Console.Write(" Nice, aber");
                            }
                            if (allowedTries - numberOfTries != 1)
                            {
                                Console.Write("Sie hatten noch " + (allowedTries - numberOfTries) + " Versuche übrig. ");
                                break;
                            }

                            if (allowedTries - numberOfTries == 1)
                            {
                                Console.Write("Sie hatten nur noch " + (allowedTries - numberOfTries) + " Versuch übrig. ");
                                break;
                            }
                        }
                    }
                }
                else
                {
                    Console.Write("Sind Sie dumm? Geben Sie eine Zahl zwischen 1 und 100 ein: ");
                    guessAsString = Console.ReadLine();
                    parseSuccess = int.TryParse(guessAsString, out guess);
                }

            }
        }
    }
}
