using UnityEditor;
using UnityEngine;

public static class PrimaryButton
{
    public static bool Draw(string text)
    {
        return GUILayout.Button(text, GUILayout.Height(35));
    }
}