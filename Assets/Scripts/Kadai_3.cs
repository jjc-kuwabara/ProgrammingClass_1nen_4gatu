using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kadai_3 : MonoBehaviour
{
    void Start()
    {

    }

    // サイコロを振る関数.
    public void RollSaikoro()
    {
        // 整数（Integer）の値を格納するための、int型の変数を宣言する.
        // 変数の名前は、randomSaikoro_Playerである.
        int randomSaikoro_Player;
        // 変数の名前は、randomSaikoro_Enemyである.
        int randomSaikoro_Enemy;

        // 1から6までの値を出す乱数を使って、サイコロの目を指定する.
        randomSaikoro_Player = Random.Range(1, 6 + 1);
        randomSaikoro_Enemy = Random.Range(1, 6 + 1);

        // サイコロの目の値を指定して、画像を変える.
        JJC.SetPlayerSaikoro(randomSaikoro_Player);
        JJC.SetEnemySaikoro(randomSaikoro_Enemy);

        // 確認のため、文字列を表示する.
        Debug.Log("あなたは" + randomSaikoro_Player.ToString() + "の目を出した.ライバルは" + randomSaikoro_Enemy.ToString() + "の目を出した");

        string[] resultStrings = new string[3];
        resultStrings[0] = "あなたの勝ち";
        resultStrings[1] = "あなたの負け";
        resultStrings[2] = "引き分け";

        // あなたの目の方が大きかったら、あなたの勝ちと表示してください.
        // あなたの目の方が小さかったら、あなたの負けと表示してください.
        // 同じ目だったら、引き分けと表示してください.
        JJC.KickPopUpMsgBox("文字列を未設定");
    }
}
