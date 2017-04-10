using System;

namespace oop_csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Vehicle myCar = new Vehicle(5);
            Vehicle myBike = new Vehicle(2);
            System.Console.WriteLine(myCar.numPassenger);
            System.Console.WriteLine(myBike.numPassenger);
            myBike.Move(1.7532);
            myCar.Move(10.3158);
            System.Console.WriteLine("my bike went {0} miles, my car went {1} miles",myBike.distance,myCar.distance);
        }
    }
}
