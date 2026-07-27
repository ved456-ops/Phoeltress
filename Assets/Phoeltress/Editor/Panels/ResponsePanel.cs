using UnityEditor;
using UnityEngine;

public static class ResponsePanel
{
    public static void Draw()
    {
        GUILayout.Space(15);

        GUILayout.Label("AI Response", EditorStyles.boldLabel);

        AIResponse response = ResponseManager.GetResponse();

        if (response == null)
        {
            EditorGUILayout.HelpBox("No response yet.", MessageType.Info);
            return;
        }

        EditorGUILayout.HelpBox(response.Text, MessageType.Info);
    }
}