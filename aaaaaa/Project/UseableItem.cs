public class UseableItem : Item{
    private int numberOfUses;
    private int timesUsed;

    public int NumberOfUses{
        get{ return numberOfUses;}
        set{ numberOfUses = value; }
    }
    public int TimesUsed{
        get{ return timesUsed;}
        set{ timesUsed = value; }
    }
}