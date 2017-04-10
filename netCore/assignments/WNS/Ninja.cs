using System;

public class Ninja : Human{
    public Ninja(string newname) : base(newname){
        dexterity = 175;
    }

    public void Steal(object obj){
        Human enermy = obj as Human;
        if(obj == null){
            System.Console.WriteLine("Stealing fail");
        }else{
            attack(enermy);
            health += 10;
        }
    }
    public void Get_away(){
        health -= 15;
    }
}