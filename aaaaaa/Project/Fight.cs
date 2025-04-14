using System.Runtime.CompilerServices;

public class Fight : Room{
    //enemy contained within

    private Enemy encounter;

    public Enemy Encounter{
        get{ return encounter; }
        set{ encounter = value; }
    }

    public Fight(Enemy encounter){
        this.encounter = encounter;
    }


    
}