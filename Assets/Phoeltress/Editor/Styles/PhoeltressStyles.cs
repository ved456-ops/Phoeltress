using UnityEditor;
using UnityEngine;

public static class PhoeltressStyles
{
    private static GUIStyle title;

    public static GUIStyle Title
    {
        get
        {
            if (title == null)
            {
                title = new GUIStyle(EditorStyles.boldLabel)
                {
                    fontSize = 20,
                    alignment = TextAnchor.MiddleCenter
                };
            }

            return title;
        }
    }
}