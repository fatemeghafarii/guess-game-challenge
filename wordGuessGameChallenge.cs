using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Collections;
namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        { 
            int min = 0;
            int max = 100;
            int round = 0;
            int guessUser = 0;
            var again = "";
            bool againGame = true;
            Random random = new Random();
            while(againGame == true)
            {
                int guessSystem = random.Next(min, max + 1);
                while(guessUser != guessSystem)
                {
                    Console.WriteLine($"Guess a number between {min} - {max} : ");
                    guessUser = Convert.ToInt32(Console.ReadLine()); 
                    Console.WriteLine($"Guess: {guessUser}");

                    if(guessUser > guessSystem)
                    {
                        Console.WriteLine($"{guessUser} is too high!");
                    }
                    else if(guessUser < guessSystem)
                    {
                        Console.WriteLine($"{guessUser} is too low!");
                    }
                    round ++;
                }
                Console.Clear();
                Console.WriteLine($"Number: {guessUser}");
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Round: ");
                Console.WriteLine("Would you like to play again (Y/N): ");
                again = Console.ReadLine();
                again = again.ToUpper();
                if(again == "Y")
                {
                    againGame = true;
                }
                else
                {
                    againGame = false;
                }
            }   
            Console.WriteLine("tnx");    
        }         
    }
}

