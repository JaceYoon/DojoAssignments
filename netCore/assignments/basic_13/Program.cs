using System;

namespace basic_13
{
    class Program
    {
        static void Print1to255(){
            for(int i = 0; i < 256; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void OddNum1to255(){
            for(int i = 0; i < 256; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void PrintSum(){
            int sum = 0;
            for(int i = 0; i < 256; i++)
            {
                sum += i;
                Console.WriteLine("New number : " + i + " " + "Sum : " + sum);
            }
        }

        static void IteratingArray(int[] arr){
            string output = "[";
            for(int i = 0; i < arr.Length; i++)
            { 
                if( i == arr.Length-1)
                {
                    output += arr[i];
                }
                else
                {
                    output += arr[i] + ",";
                }
            }
            output += "]";
            System.Console.WriteLine(output);
        }
        static void Max(int[] arr){
            var maxNum = 0;
            for(var i = 0; i < arr.Length; i++){
                if(arr[i] > maxNum){
                    maxNum = arr[i];
                }
            }
            System.Console.WriteLine("Max is : " + maxNum);
        }

        static void Average(int[] arr){
            var sum = 0;
            for(var i = 0; i < arr.Length; i++){
                sum += arr[i];
            }
            System.Console.WriteLine("Average is :" + sum/arr.Length);
        }

        static void GreaterThanY(int[] arr){
            var y = -3;
            var count = 0;
            for(var i = 0; i < arr.Length; i++){
                if(arr[i] > y){
                    count ++;
                }
            }
            System.Console.WriteLine("GreaterThanY runs " + count + "times.");
        }

        static void Square(int[] arr){
            int[] newArr = new int[6];
            for(var i = 0; i < arr.Length; i++){
                arr[i] = arr[i] * arr[i];
                newArr[i] = arr[i];
            }
            IteratingArray(newArr);
        }

        static void Eliminate(int[] arr){
            int[] newArr = new int[6];
            for(var i = 0; i < arr.Length; i++){
                if(arr[i] < 0){
                    arr[i] = 0;
                    newArr[i] = arr[i];
                }
                newArr[i] = arr[i];
            }
            IteratingArray(newArr);
        }

        static void MinMaxAvg(int[] arr){
            var max = 0;
            var min = 0;
            var sum = 0;
            int [] newArr = new int[3];
            for(var i = 0; i < arr.Length; i++){
                if(arr[i] > max){
                    max = arr[i];
                }
                if(arr[i] < min){
                    min = arr[i];
                }
                sum += arr[i];
            }
            newArr[0] = min;
            newArr[1] = max;
            newArr[2] = sum/arr.Length;
            IteratingArray(newArr);
        }

        static void Shifting(int[] arr){
            int [] newArr = new int[6];
            for(var i = 1; i < arr.Length; i++){
                newArr[i-1] = arr[i];
                if(i == arr.Length){
                    newArr[i+1] = 0;
                }
            }
            IteratingArray(newArr);
        }

        static void NumberToString(object[] arr){
            string output = "[";
            for(var i = 0; i < arr.Length; i++){
                if(i == arr.Length-1){
                    if((int)arr[i] < 0){
                    arr[i] = "Dojo";
                    output += arr[i];
                    }
                    else{
                        output += arr[i];
                    }
                }
                else{
                    if((int)arr[i] < 0){
                    arr[i] = "Dojo";
                    output += arr[i] + ",";
                    }
                    else{
                        output += arr[i] + ",";
                    }
                 
                  }
            }
                
            output += "]";

            System.Console.WriteLine(output);
        }
        static void Main(string[] args){
            Print1to255();
            OddNum1to255();
            PrintSum();
            int[] myArr = new int[6] {-8,0,-150,7,23,3};
            object[] myArr_2 = new object[6] {-8,0,-150,7,23,3};
            IteratingArray(myArr);
            Max(myArr);
            Average(myArr);
            GreaterThanY(myArr);
            Square(myArr);
            Eliminate(myArr);
            MinMaxAvg(myArr);
            Shifting(myArr);
            NumberToString(myArr_2);
        }
        
    }
}
