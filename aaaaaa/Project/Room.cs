public class Room{
    private string description = "";
    private string location = "";
    private Boolean isCleared = false;

    public string Description {
         get { return description;}
         set { description = value; }
    }
    public string Location {
         get { return location;}
         set { location = value; }
    }
    public Boolean IsCleared {
         get { return isCleared;}
         set { isCleared = value; }
    }        
}