namespace GameMaster.Services;

/// <summary>
/// Placeholder for local LLM integration.
/// The private repo wires this to llama.cpp / LLamaSharp for offline inference.
/// </summary>
public class LlamaLocal
{
    public string Generate(string prompt)
    {
        // No real inference in this public showcase.
        return "LLM output is disabled in the showcase version.";
    }
}
