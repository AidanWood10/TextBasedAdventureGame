public class Item{
    private string name = "";
    private string description = "";
    private int statChange;

    //Yeah im not sure how to do this one yet
    //private string affectedStat = "";

    public string Name {
     get { return name;}
     set { name = value;}
    }
    public string Description {
     get { return description;}
     set { description = value;}
    }
    public int StatChange {
     get { return statChange;}
     set { statChange = value;}
    }
}