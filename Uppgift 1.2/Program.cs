using System;
using System.Runtime.CompilerServices;

namespace Uppgift_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White; //Text färg vit
            Console.BackgroundColor = ConsoleColor.DarkBlue; //Bakgrundfärg blå i terminalen
            Console.Clear(); //Gör så att bara min bakgrundsfärg gäller
            Console.WriteLine("!!WARNING!! VIRUS DETECTED !!WARNING!!"); //Lite text 
            Console.ReadKey(); 
        }
    }
}