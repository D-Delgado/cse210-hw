public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailString()
    {
        string dString = "";
        if (IsComplete() == true)
        {
            dString = $"[X] {_shortName} ({_description})";
        }
        else
        {
            dString = $"[ ] {_shortName} ({_description})";
        }
        
        return dString;
        
    }
    public abstract string GetStringRepresentation();
}