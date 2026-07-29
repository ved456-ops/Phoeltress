using System.Collections.Generic;

public static class HistoryManager
{
    private static List<ConversationEntry> history = new List<ConversationEntry>();

    private static ConversationEntry selectedConversation;

    public static void AddEntry(ConversationEntry entry)
    {
        history.Add(entry);
    }

    public static List<ConversationEntry> GetHistory()
    {
        return history;
    }

    public static void ClearHistory()
    {
        history.Clear();
    }

    public static int GetCount()
    {
        return history.Count;
    }

    public static void SetSelectedConversation(ConversationEntry entry)
    {
        selectedConversation = entry;
    }

    public static ConversationEntry GetSelectedConversation()
    {
        return selectedConversation;
    }
}