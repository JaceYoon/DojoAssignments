using System;
using System.Collections.Generic;
using System.Linq;

namespace puzzle
{
    class Program
    {
        static void RandomArray(){
            var rand = new Random();
            var sum = 0;
            int[] newArr = new int[10];
            for(var i = 0; i < 10; i++){
                newArr[i] = rand.Next(5,26);
                sum += newArr[i];
            }
            foreach (var arr in newArr)
            {
                System.Console.WriteLine(arr);
            }
            System.Console.WriteLine("The max value is {0}", newArr.Max());
            System.Console.WriteLine("The max value is {0}", newArr.Min());
            System.Console.WriteLine("Sum is {0}", sum);
        }

        static string TossCoin(Random rand){
            Console.WriteLine("Tossing a Coin!");
            string result = "Tails";
            if(rand.Next(0,2) == 1){
                result = "Heads";
            }
            System.Console.WriteLine($"You filped a {result}");
            return result;
        }

         static double TossMultipleCoins(int num){
            int numheads =0;
            Random rand = new Random();

            for(int i = 0 ; i < num ; i++)
            {
                if(TossCoin(rand) == "Heads")
                {
                    numheads ++;
                }
            }
            return (double)numheads/num;
        }

        static void Main(string[] args){
            // RandomArray();
            // TossCoin(new Random());
            System.Console.WriteLine(TossMultipleCoins(5));
        }
    }
}
