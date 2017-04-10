using System;
using System.Collections.Generic;


namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {   
            // start practicing

            // object BoxedData = "This is clearly a string";
            // if (BoxedData is int) {
            //     //This shouldn't run
            //     Console.WriteLine("I guess we have an integer value in this box?");
            // }
            // if (BoxedData is string) {
            //     Console.WriteLine("It is totally a string in the box!");
            // }

            // object ActuallyString = "a string";
            // string ExplicitString = ActuallyString as string;
            // Console.WriteLine(ExplicitString);
            // Console.WriteLine(ActuallyString);  
            
            // end practicing

            List<object> myList = new List<object>();
            myList.Add(7);
            myList.Add(28);
            myList.Add(-1);
            myList.Add(true);
            myList.Add("chair");
            int sum = 0;
            foreach (var obj in myList)
            {
                Console.WriteLine(obj);
                    if(obj is int)
                    {
                        sum += (int)obj;
                    }
                Console.WriteLine("sum is : " + sum);
            }
        }
    }
}
