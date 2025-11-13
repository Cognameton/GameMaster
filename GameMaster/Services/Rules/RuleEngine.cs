namespace GameMaster.Services.Rules;

/// <summary>
/// Placeholder for core rules processing, dice resolution, and game logic.
/// The private version includes a modular rule engine for various RPG systems.
/// </summary>
public class RuleEngine
{
    public int RollDie(int sides)
    {
        // Basic behavior shown for demonstration only.
        return new System.Random().Next(1, sides + 1);
    }
}
