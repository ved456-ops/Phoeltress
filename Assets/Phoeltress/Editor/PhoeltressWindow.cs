using UnityEditor;
using UnityEngine;

public class PhoeltressWindow : EditorWindow
{
    [MenuItem("Tools/Phoeltress/Open Phoeltress")]
    public static void ShowWindow()
    {
        GetWindow<PhoeltressWindow>("Phoeltress");
    }

    private void OnGUI()
    {
        GUILayout.Label("🔥 Welcome to Phoeltress!", EditorStyles.boldLabel);

        GUILayout.Space(10);

        GUILayout.Label("AI-Powered Game Development Platform");
    }
}