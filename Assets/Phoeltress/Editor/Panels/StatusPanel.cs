using UnityEditor;
using UnityEngine;

public static class StatusPanel
{
    public static void Draw()
    {
        GUILayout.Label("Status");

        EditorGUILayout.LabelField("AI", StatusManager.GetStatus());
        EditorGUILayout.LabelField("Unity", Application.unityVersion);
        EditorGUILayout.LabelField("Project", Application.productName);
    }
}