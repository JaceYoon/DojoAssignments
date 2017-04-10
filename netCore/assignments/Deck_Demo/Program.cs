using System;

namespace Deck_Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lets play card game!");
            Deck myDeck = new Deck();
            myDeck.Shuffle();
            Player Jace = new Player("Jace");
            Player Taylor = new Player("Taylor");   

            Jace.Draw(myDeck);         
            Jace.Draw(myDeck);
            Jace.Draw(myDeck);
            Jace.Draw(myDeck);

            System.Console.WriteLine(Jace.Hand);

            Jace.Discard(3);

            System.Console.WriteLine(Jace.Hand);
            
        }
    }
}
