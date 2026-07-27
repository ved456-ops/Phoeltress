using UnityEditor;
using UnityEngine;

public static class PromptPanel
{
    public static void Draw(ref string prompt)
    {
        GUILayout.Label("Prompt");

        prompt = EditorGUILayout.TextArea(prompt, GUILayout.Height(80));

        GUILayout.Space(10);

        if (PrimaryButton.Draw("Generate"))
        {
            if (PromptManager.Validate(prompt))
            {
                AIResponse response = AIConnector.SendPrompt(prompt);

                ResponseManager.SetResponse(response);
            }
        }

        GUILayout.Space(20);
    }
}