namespace Human{
    public class Human{
        public string name;
        public int strength;
        public int intelligence;
        public int dexterity;
        public int health;
        public Human(string newname, int newstr, int newint, int newdex, int newhp){
            name = newname;
            strength = newstr;
            intelligence = newint;
            dexterity = newdex;
            health = newhp;
        }

        public void Attack(object target){
            Human enemy = target as Human;
            if(enemy != null){
                enemy.health -= 5 * strength;
            }
        }
    }
}