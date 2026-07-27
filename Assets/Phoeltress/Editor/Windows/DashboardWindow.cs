using UnityEditor;
using UnityEngine;

public class DashboardWindow : EditorWindow
{
    [MenuItem("Tools/Phoeltress/Open Dashboard")]
    public static void ShowWindow()
    {
        GetWindow<DashboardWindow>("Phoeltress");
    }

    private string prompt = "";

    private void OnGUI()
    {
        HeaderPanel.Draw();

        PromptPanel.Draw(ref prompt);

        ResponsePanel.Draw();
        
        StatusPanel.Draw();
    }
}