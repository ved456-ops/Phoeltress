public static class StatusManager
{
    public static string AIStatus { get; private set; } = "Offline";

    public static void SetStatus(string status)
    {
        AIStatus = status;
    }

    public static string GetStatus()
    {
        return AIStatus;
    }
}