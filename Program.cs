using System;
using System.Collections.Generic;

namespace _10010463_assessment3_question01
{
    class Program
    {   
        static List<string> Falconers = new List<string> {"Debble", "Heidi", "Noel", "Melissa", "Kirsten", "koshy"};
        static List<string> Falcons = new List<string> {"Hisan", "Ka Kite", "Siren", "Koa", "Stella", "Mojo"};

        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();
            
            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
            
                
        Console.WriteLine(Falconsandfalconers());
       
        // Console.ReadLine();
        }
        static int random(List<string> myList)
                    {
                var rand = new Random();
                return rand.Next(1, myList.Count);
              
                    }
                static string Falconsandfalconers()
                {
                    var randomFaclcon = Falcons[random(Falcons)];
                    var randomFalconers = Falconers[random(Falconers)];
                    return $"Flacon trainer is {randomFalconers} and the falcon is {randomFaclcon}";
                }
    }
}

