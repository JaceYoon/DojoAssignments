using System;
using System.Collections.Generic;
namespace ConsoleApplication
{
    public class Program
    {
        // public static void SayHello(string name = "Jace")
        // {
        //     Console.WriteLine("Hello how are you doing today?" + name);
        // }

        public static string SayHello(string name = "buddy")
        {
            return $"Hey {name}";
        }
        
                
        public static void Main(string[] args)
        {
            SayHello("Yoda");
            string greeting;
            greeting = SayHello();
            Console.WriteLine(greeting);
        }
    }
}