using UnityEngine;

public static class AIConnector
{
    public static AIResponse SendPrompt(string prompt)
    {
        return new AIResponse
        {
            Text =
                $"[Phoeltress AI]\n\n" +
                $"Prompt Received:\n{prompt}\n\n" +
                $"This is a simulated AI response.\n" +
                $"Later this method will communicate with LM Studio.",

            Success = true,

            ExecutionTime = 0.12f,

            ErrorMessage = ""
        };
    }
}