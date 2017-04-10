using System;
using System.Collections.Generic;
using System.Linq;

namespace puzzle
{
    class Program{
        static void Main(string[] args){
            // RandomArray();
            // CoinFlip(new Random());
            
            // System.Console.WriteLine(TossMultipleCoins(5));
            Names();
        }

        // static int[] RandomArray()
        // {   
        //     var rand = new Random();
        //     int[] MyArr = new int[10];
        //     int sum = 0;
        //     for(int i = 0; i < MyArr.Length; i++)
        //     {
        //         MyArr[i] += rand.Next(5,26);
        //         sum += MyArr[i];
                
        //     }
        //     System.Console.WriteLine($"the Sum of all the values is {sum}"); // cw is snippit
        //     System.Console.WriteLine(MyArr.Min());
        //     System.Console.WriteLine(MyArr.Max());

        //     return MyArr;
        // }

        // static int[] RandomArray()
        // {
        //     System.Console.WriteLine("hey");
        // }

        static string CoinFlip(Random rand){
            System.Console.WriteLine("Flipping a Coin");
            string result = "Tails";
            if(rand.Next(0,2) == 1)
            {
                result = "Heads";
            }
            System.Console.WriteLine($"You filpedsad a {result}");
            return result;
        }

        static double TossMultipleCoins(int num){
            int numheads =0;
            Random rand = new Random();

            for(int i = 0 ; i < num ; i++)
            {
                if(CoinFlip(rand) == "Heads")
                {
                    numheads ++;
                }
            }
            return (double)numheads/num;
        }

        static string[] Names(){
            string[] Mynames = {"Todd","Taylor","JaceYoon","IanOwen","Sera"};
            Random rand = new Random();
            
            for(int i = 0 ; i < Mynames.Length-1; i++){
                int randIdx = rand.Next(i+1, Mynames.Length); // i + 1 < no chance to swap itself ex) Todd -> Todd

                string temp = Mynames[randIdx];
                Mynames[randIdx] = Mynames[i];
                Mynames[i] = temp;
            }
            List<string> LongNames = new List<string>();
            
            for(int i = 0 ; i < Mynames.Length; i++){
                // System.Console.WriteLine(Mynames[i]);
                if(Mynames[i].Length > 5){
                    LongNames.Add(Mynames[i]);
                }
            }
            
            return LongNames.ToArray();
        }
    }
}
