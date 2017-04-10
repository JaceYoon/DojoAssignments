using System;
using System.Collections.Generic;

namespace Collections_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = new int[10] {0,1,2,3,4,5,6,7,8,9};
            
            foreach(var item in numArr)
            {
                Console.WriteLine("{0}",item);
            }
            string[] myNames = new string[] {"Tim","Martin","Nikki","Sara"};
            Console.WriteLine(myNames[2]);

            bool[] boolArr = new bool[10];
            for(int i = 0; i < 10; i +=2)
            {
                boolArr[i] = true;
            }

            int[,] mult = new int[10,10];
            for(int x = 0; x < 10; x++)
            {
                for(int y = 0; y < 10; y++)
                {
                    mult[x, y] = (x + 1) * (y + 1);
                }
            }

            List<string> IceCreams = new List<string>();

            IceCreams.Add("Chocolate");
            IceCreams.Add("Strawberry");
            IceCreams.Add("Coffee");
            IceCreams.Add("Vanilla");
            IceCreams.Add("Mango");

            foreach (string flavor in IceCreams)
            {
                Console.WriteLine("-" + flavor);
            }

            Console.WriteLine(IceCreams[3]);
            IceCreams.Remove("Coffee");
            Console.WriteLine(IceCreams.Count);;

            Dictionary<string, string> userInfo = new Dictionary<string,string>();
            Random rand = new Random();
            foreach(string name in myNames)
            {
                userInfo.Add(name,IceCreams[rand.Next(IceCreams.Count)]);
            }

            Console.WriteLine("Users and their favor ice cream flavors:");
            foreach(KeyValuePair<string, string> info in userInfo)
            {
                Console.WriteLine(info.Key + " - " + info.Value);
            }

        }
    }
}
