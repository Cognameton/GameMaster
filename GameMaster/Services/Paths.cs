namespace GameMaster.Services;

/// <summary>
/// Centralized helper for application paths (config, llm, saves, etc.).
/// Real paths and environment detection are private.
/// </summary>
public static class Paths
{
    public static string ConfigDirectory => "config";
    public static string ModelsDirectory => "llm";
}
