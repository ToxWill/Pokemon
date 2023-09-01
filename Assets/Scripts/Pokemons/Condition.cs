using System;

public class Condition
{
    public ConditionID Id { get; set; }

    public string Name { get; set; }    
    public string Discription { get; set; }    
    public string StartMessage { get; set; }

    public Action<Pokemon> OnStart { get; set; }
    public Action<Pokemon> OnAfterTurn { get; set; }

    public Func<Pokemon, bool> OnBeforeMove { get; set; }
}