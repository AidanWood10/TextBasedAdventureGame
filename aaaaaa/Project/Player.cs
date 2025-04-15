public class Player : Entity{
    private int location;
    private string itemHeld = "";

    public int Location{
        get{ return location;}
        set{ location = value;}
    }

    public string ItemHeld{
        get{ return itemHeld;}
        set{ itemHeld = value;}
    }


}