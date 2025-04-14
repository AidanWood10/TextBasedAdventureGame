public class EquippableItem : Item{
    private Boolean isHeld = false;

    public Boolean IsHeld{
        get{ return isHeld; }
        set{ isHeld = value; }
    }
}