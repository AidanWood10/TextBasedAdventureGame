//Setting getters and setters for entity class, which will be inherited by player and enemy class
public class Entity{
   private string name = "";
   private int health;
   private int damage;
   private string attackState = "";

   public string Name{
    get{return name;}
    set{name=value;}
   }

    public int Health{
        get{return health;}
        set{health=value;}
    }

    public int Damage{
        get{return damage;}
        set{damage=value;}
    }
    
    public string AttackState{
        get{return attackState;}
        set{attackState=value;}
    }

}