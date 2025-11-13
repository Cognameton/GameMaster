namespace GameMaster.Services;

/// <summary>
/// Registry of available AI models.
/// The private repo scans the filesystem and configuration for GGUF models.
/// </summary>
public class ModelRegistry
{
    public string[] ListRegisteredModels()
    {
        return System.Array.Empty<string>();
    }
}
