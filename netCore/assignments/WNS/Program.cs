using System;

namespace WNS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Wizard Jace = new Wizard("Jace");
            Human Taylor = new Human("Taylor");
            Ninja Ian = new Ninja("Ian");
            Samurai Sam = new Samurai("Sam");
            Samurai Eevee = new Samurai("Eevee");
            Samurai Sera = new Samurai("Sera");
            // Jace.Fireball(Taylor);
            // Jace.Heal(Jace);
            // Ian.Get_away();
            // Ian.Steal(Taylor);
            // Jace.Fireball(Taylor);
            // System.Console.WriteLine(Taylor.health);
            // Jace.Fireball(Taylor);
            // System.Console.WriteLine(Taylor.health);
            // Jace.Fireball(Taylor);
            // System.Console.WriteLine(Taylor.health);
            // Sam.Death_blow(Taylor);
            // System.Console.WriteLine(Taylor.health);

            // Eevee.how_many();
            // System.Console.WriteLine("{0} got fireball by {1}, {0}'s health is currently have {2}",Taylor.name,Jace.name,Taylor.health);
            // System.Console.WriteLine("{0} attack {1}, {0} health is {2}, {1} health is {3}",Ian.name, Taylor.name, Ian.health, Taylor.health);
            Console.WriteLine("Enter input:");
            
            bool GameOn = true;
            bool GameOnR = true;

            while(GameOnR == true){
                string line = Console.ReadLine();
                while(GameOn == true){
                    if(line == "attack Taylor"){
                    Jace.attack(Taylor);
                    System.Console.WriteLine("{0} attacked {1}, and {1} have {2} hp now.",Jace.name, Taylor.name, Taylor.health);
                    line = Console.ReadLine();
                }
                if(line == "fireball Taylor"){
                    Jace.Fireball(Taylor);
                    System.Console.WriteLine("{0} spelled fireball to {1}, and {1} have {2} hp now.",Jace.name, Taylor.name, Taylor.health);
                    
                    string line2 = Console.ReadLine();
                    if(line2 == "fireball Taylor"){
                        Jace.Fireball(Taylor);
                        System.Console.WriteLine("{0} spelled fireball to {1}, and {1} have {2} hp now.",Jace.name, Taylor.name, Taylor.health);

                    string line3 = Console.ReadLine();
                    if(line3 == "Death"){
                        Eevee.Death_blow(Taylor);
                        System.Console.WriteLine("{0} did deathblow to {1}, and {1} have {2} hp now", Eevee.name, Taylor.name, Taylor.health);
                        if(Taylor.health == 0){
                            System.Console.WriteLine("Game over");
                                GameOn = false;
                                GameOnR = false;
                            }
                     }
                    }
                }
                if(line == "Death blow"){
                    Eevee.Death_blow(Taylor);
                    System.Console.WriteLine("{0} did deathblow to {1}, and {1} have {2} hp now", Eevee.name, Taylor.name, Taylor.health);    
                    }
                }
                if(Taylor.health == 0){
                    GameOn = false;
                    GameOnR = false;
                }
                else{
                    System.Console.WriteLine("you Typed wrong");
                }
            }
            
        }
    }
}
