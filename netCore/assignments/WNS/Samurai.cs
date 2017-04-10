using System;

public class Samurai : Human{
    public static int count =0;
    public Samurai(string newname):base(newname){
        health = 200;
        count ++;
    }

    public void Death_blow(object obj){
        Human target = obj as Human;
        if(target.health < 50){
            target.health = 0;
        }else{
            attack(target);
        }
    }

    public void Meditata(){
        health = 200;
    }

    public void how_many(){
        System.Console.WriteLine(count);
    }
}