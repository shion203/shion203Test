using UnityEditor;
using UnityEngine;

public class BuildClass : MonoBehaviour
{
    public static void Build()
    {
        // ビルド対象シーンリスト
        string[] sceneList = {
            "./Assets/scene1.unity",
        };

        // 実行
        var errorMessage = BuildPipeline.BuildPlayer(
                sceneList,                          //!< ビルド対象シーンリスト
                "C:/test/myUnityProj.exe",   //!< 出力先
                BuildTarget.StandaloneWindows,      //!< ビルド対象プラットフォーム
                BuildOptions.Development            //!< ビルドオプション
        );

        // 結果出力
        if (!string.IsNullOrEmpty(errorMessage.ToString()))
            Debug.LogError("[Error!] " + errorMessage.ToString());
        else
            Debug.Log("[Success!]");
    }
}
