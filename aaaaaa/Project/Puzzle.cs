public class Puzzle : Room{
    private string question = "";
    private string solution = "";
    private int guessesTaken;

    public string Question{
        get{ return question; }
        set{ question = value; }
    }
    public string Solution{
        get{ return solution; }
        set{ solution = value; }
    }
    public int GuessesTaken{
        get{ return guessesTaken; }
        set{ guessesTaken = value;}
    }
}