using UnityEngine;
using UnityEditor;

public class EditorWindowSample : EditorWindow
{
    [MenuItem("Editor/Sample")]
    private static void Create()
    {
        // 生成
        GetWindow<EditorWindowSample>("サンプル");
    }
}