using UnityEditor;
using UnityEngine;
using System.Collections.Generic;

public static class HistoryPanel
{
    // Remembers the scrollbar position
    private static Vector2 scrollPosition = Vector2.zero;

    public static void Draw()
    {
        GUILayout.Space(15);

        // =========================
        // Header
        // =========================

        GUILayout.BeginHorizontal();

        GUILayout.Label(
            $"Conversation History ({HistoryManager.GetCount()})",
            EditorStyles.boldLabel
        );

        GUILayout.FlexibleSpace();

        if (GUILayout.Button("🗑 Clear History", GUILayout.Width(120)))
        {
            HistoryManager.ClearHistory();
        }

        GUILayout.EndHorizontal();

        GUILayout.Space(10);

        // =========================
        // Get History
        // =========================

        List<ConversationEntry> history = HistoryManager.GetHistory();

        if (history.Count == 0)
        {
            EditorGUILayout.HelpBox(
                "No conversation history yet.",
                MessageType.Info
            );

            return;
        }

        // =========================
        // Scroll View Starts
        // =========================

        scrollPosition = EditorGUILayout.BeginScrollView(
            scrollPosition,
            GUILayout.Height(200)
        );

        foreach (ConversationEntry entry in history)
        {
            GUILayout.BeginVertical("box");

            if (GUILayout.Button($"💬 {entry.Prompt}", GUILayout.Height(30)))
            {
                HistoryManager.SetSelectedConversation(entry);
                ResponseManager.SetResponse(entry.Response);
            }
            {
                HistoryManager.SetSelectedConversation(entry);
                ResponseManager.SetResponse(entry.Response);
            }

            GUILayout.Label(
                entry.Timestamp.ToString("HH:mm:ss"),
                EditorStyles.miniLabel
            );

            GUILayout.EndVertical();

            GUILayout.Space(5);
        }

        EditorGUILayout.EndScrollView();

        // =========================
        // Scroll View Ends
        // =========================
    }
}