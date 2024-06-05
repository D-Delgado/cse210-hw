public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public override void RecordEvent()
    {   
        _isComplete = true;
        GetDetailString();
    }
    public override bool IsComplete()
    {
        bool IsComplete;
        if (_isComplete == false)
        {
            IsComplete = false;
        }
        else
        {
            IsComplete = true;
        }
        return IsComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal | {_shortName} | {_description} | {_points} | {_isComplete}";
    }
}