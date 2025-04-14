public class Player : Entity{
    private string location = "";
    private string itemHeld = "";

    public string Location{
        get{ return location;}
        set{ location = value;}
    }

    public string ItemHeld{
        get{ return itemHeld;}
        set{ itemHeld = value;}
    }

    
}