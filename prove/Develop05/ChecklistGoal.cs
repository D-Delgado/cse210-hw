public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        if (_target == _amountCompleted)
        {
            IsComplete();
            GetDetailString();
        }
        if (_target > _amountCompleted)
        {
            _amountCompleted += 1;
            GetDetailString();
        }
    }
    public override bool IsComplete()
    {
        bool IsComplete;
        if (_target == _amountCompleted)
        {
            IsComplete = true;
        }
        else
        {
            IsComplete = false;
        }
        return IsComplete;
    }
    public override string GetDetailString()
    {
        string dString = "";
        if (IsComplete() == true)
        {
            dString = $"[X] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
        }
        else
        {
            dString = $"[ ] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
        }
        
        return dString;
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal | {_shortName} | {_description} | {_points} | {_bonus} | {_target} | {_amountCompleted}";
    }
    public int GetTarget()
    {
        return _target;
    }
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
}