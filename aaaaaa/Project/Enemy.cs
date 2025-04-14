public class Enemy : Entity{
    private string description = "";

    public string Description {
        get { return description; }
        set { description = value; }
    }

//yeah I got no idea whats going on here
    public Enemy (string name, string description,int health,int damage,string attackState){
        this.Name = name;
        this.Description = description;
        this.Health = health;
        this.Damage = damage;
        this.AttackState = attackState;

    }



    

}