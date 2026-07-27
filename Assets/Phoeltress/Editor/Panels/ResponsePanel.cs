using UnityEditor;
using UnityEngine;

public static class ResponsePanel
{
    public static void Draw()
    {
        GUILayout.Space(15);

        // Get the response ONCE
        AIResponse response = ResponseManager.GetResponse();

        GUILayout.BeginHorizontal();

        GUILayout.Label("AI Response", EditorStyles.boldLabel);

        GUILayout.FlexibleSpace();

        if (GUILayout.Button("📋 Copy", GUILayout.Width(70)))
        {
            if (response != null)
            {
                EditorGUIUtility.systemCopyBuffer = response.Text;
            }
        }

        if (GUILayout.Button("🗑 Clear", GUILayout.Width(70)))
        {
            ResponseManager.ClearResponse();
        }

        GUILayout.EndHorizontal();

        if (response == null)
        {
            EditorGUILayout.HelpBox("No response yet.", MessageType.Info);
            return;
        }

        EditorGUILayout.HelpBox(response.Text, MessageType.Info);
    }
}