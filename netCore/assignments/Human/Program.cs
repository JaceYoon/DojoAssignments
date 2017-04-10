using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Jace = new Human("Jace",101,870,50,7800);
            Human Taylor = new Human("Talyor",55,750,900,7600);

            Jace.Attack(Taylor);
            Taylor.Attack(Jace);

            System.Console.WriteLine("{0} attacking {1}, {1} have {2} hp remaining now",Jace.name, Taylor.name, Taylor.health);
            System.Console.WriteLine("{0} attacking {1}, {1} have {2} hp remaining now",Taylor.name, Jace.name, Jace.health);
        }
    }
}
