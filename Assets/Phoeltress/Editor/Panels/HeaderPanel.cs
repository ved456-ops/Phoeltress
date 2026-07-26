using UnityEditor;
using UnityEngine;

public static class HeaderPanel
{
    public static void Draw()
    {
        GUILayout.Space(10);

        GUILayout.Label("PHOELTRESS", PhoeltressStyles.Title);

        GUILayout.Label("AI Operating System for Unity");

        GUILayout.Space(15);
    }
}