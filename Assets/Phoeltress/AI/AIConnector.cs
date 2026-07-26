public static class AIConnector
{
    public static string SendPrompt(string prompt)
    {
        return
            $"[Phoeltress AI]\n\n" +
            $"Prompt Received:\n{prompt}\n\n" +
            $"This is a simulated AI response.\n" +
            $"Later this method will communicate with LM Studio.";
    }
}