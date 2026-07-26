using UnityEngine;

public static class PromptManager
{
    public static bool Validate(string prompt)
    {
        if (prompt == null)
        {
            Debug.LogError("Prompt is null.");
            return false;
        }

        prompt = prompt.Trim();

        if (prompt.Length == 0)
        {
            Debug.LogError("Prompt is empty.");
            return false;
        }

        if (prompt.Length > 1000)
        {
            Debug.LogError("Prompt exceeds the maximum length.");
            return false;
        }

        return true;
    }
}