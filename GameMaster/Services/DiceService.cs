namespace GameMaster.Services;

/// <summary>
/// Simple dice utility for demonstration.
/// The private version supports complex roll expressions and rule integration.
/// </summary>
public class DiceService
{
    private readonly System.Random _random = new();

    public int Roll(int sides)
    {
        return _random.Next(1, sides + 1);
    }
}
