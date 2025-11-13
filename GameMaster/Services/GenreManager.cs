namespace GameMaster.Services;

/// <summary>
/// Handles genre presets (fantasy, sci-fi, cyberpunk, etc.).
/// The private version tunes prompts, rules, and content packs by genre.
/// </summary>
public class GenreManager
{
    public string[] ListGenres()
    {
        return new[] { "Fantasy", "Sci-Fi", "Horror", "Showcase-Only" };
    }
}
