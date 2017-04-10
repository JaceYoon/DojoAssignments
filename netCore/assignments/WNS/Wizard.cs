using System;
public class Wizard : Human{
    public Wizard(string newname) : base(newname){
        health = 50;
        intelligence = 25;
    }

    public void Heal(object obj){
        Human target = obj as Human;
        if(obj == null){
            System.Console.WriteLine("Fail to heal");
        }else{
            if(target.health < 50){
                target.health += intelligence * 2;
            }else{
                target.health = 100;
            }
            
        }
    }
    public void Fireball(object obj){
        Random rand = new Random();
        Human enermy = obj as Human;
        if(obj == null){
            System.Console.WriteLine("Fail to cast fireball ");
        }else{
            enermy.health -= rand.Next(20,51);
        }
    }
}