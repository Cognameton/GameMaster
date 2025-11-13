namespace GameMaster.Services;

/// <summary>
/// Handles graceful shutdown in the private application.
/// Closes sessions, flushes logs, and saves state.
/// </summary>
public static class ShutdownUtil
{
    public static void Shutdown()
    {
        // No-op in showcase.
    }
}
