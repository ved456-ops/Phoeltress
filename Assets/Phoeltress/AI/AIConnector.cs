
public static class AIConnector
{
    public static AIResponse SendPrompt(string prompt)
    {
        return LMStudioService.Send(prompt);
    }
}