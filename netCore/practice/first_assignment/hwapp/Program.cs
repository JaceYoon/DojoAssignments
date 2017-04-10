using System;

namespace hwapp
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int val = 1; val < 256; val++)
            {
                Console.WriteLine(val); //problem 1 showing 1-255 nums
            }

            for(int val = 1; val < 100; val++)
            {
                if(val % 3 == 0)
                {
                    if((val % 15 != 0)){
                        Console.WriteLine(val); //problem 2 divisible by 3 or 5, but not both
                    }
                }

                if(val % 5 == 0)
                {
                    if((val % 15 != 0)){
                        Console.WriteLine(val); //problem 2 divisible by 3 or 5, but not both
                    }
                }
            }

            for(int val = 1; val < 100; val++)
            {
                if(val % 3 == 0)
                {
                    if((val % 15 != 0)){
                        Console.WriteLine("Fizz :"+3); //problem 3
                    }
                }

                if(val % 5 == 0)
                {
                    if((val % 15 != 0)){
                        Console.WriteLine("Buzz :"+5); //problem 3 
                    }
                }


                if(val % 15 == 0)
                {
                        Console.WriteLine("FizzBuzz :"+15); //problem 3
                }
            }

            int three = 3;  //problem 4 (optional)
            int five = 5;
            for (int num = 1; num < 101; num++)
            {
                three--;
                five--;
                if (three == 0 && five == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    three = 3;
                    five = 5;
                }
                else if (three == 0)
                {
                    Console.WriteLine("Fizz");
                    three = 3;
                }
                else if (five == 0) {
                    Console.WriteLine("Buzz");
                    five = 5;
                }
            }       //end problem 4

            Random rand  = new Random(); //Start Problem 5 (optional)

            for(int val = 0; val < 10; val++)
            {       
                int ranran = rand.Next(1,100);
                Console.WriteLine("My Random num is" + ranran);

                if(ranran % 3 == 0){
                    if((ranran % 15 !=0))
                    {
                        Console.WriteLine(ranran + "Fizz");
                    }                    
                }
                if(ranran % 5 == 0){
                    if((ranran % 15 !=0))
                    {
                        Console.WriteLine(ranran + "Buzz");
                    }                    
                }
                if(ranran % 15 == 0){
                        Console.WriteLine(ranran + "FizzBuzz");               
                }
            }       //end Problem 5 

        }
    }
}
