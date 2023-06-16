using System;

public class Condition
{
    public string Name { get; set; }
    
    public string Discription { get; set; }
    
    public string StartMessage { get; set; }

    public Action<Pokemon> OnAfterTurn { get; set; }
}
