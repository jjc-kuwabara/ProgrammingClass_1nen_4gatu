using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kadai_2 : MonoBehaviour
{
    void Start()
    {
        // サイコロを振る関数を呼び出す.
        RollSaikoro();
    }

    // サイコロを振る関数.
    public void RollSaikoro()
    {
        // 整数（Integer）の値を格納するための、int型の変数を宣言する.
        // 変数の名前は、randomSaikoroである.
        int randomSaikoro;

        // randomSaikoroという変数に、値を格納する.
        // 1から6までの値を出す乱数を使って、サイコロの目を指定する.
        randomSaikoro = Random.Range(1, 6 + 1);

        // サイコロの目の値を指定して、画像を変える.
        JJC.SetSaikoro(randomSaikoro);

        // 確認のため、文字列を表示する.
        Debug.Log(randomSaikoro.ToString() + "の目が出た.");

        // 例.
        if ( randomSaikoro > 4 )
        {
            Debug.Log("randomSaikoroは4より大きい！");
        }

        ///////////////////////////////// 課題 //////////////////////////////////////////////////
        // 以下のようなif文を使って、サイコロの目が3以下の時、特別な表示を行ってください.
        // 文字列は、"（ダブルクォーテーション：Shift + 2で入力できます）で前後を挟むことで、文字列である、とプログラムが認識します.
        /*

        if( 条件式 ){
            Debug.Log(" 表示したい文字列 ");
        }

         */

        // 条件式の書き方.
        // randomSaikoro == 1   randomSaikoro変数の値が、1である場合、真（true）となる.
        // randomSaikoro < 1    randomSaikoro変数の値が、1未満である場合、真（true）となる.
        // randomSaikoro <= 1   randomSaikoro変数の値が、1以下である場合、真（true）となる.
        // randomSaikoro > 1    randomSaikoro変数の値が、1より大きいである場合、真（true）となる.
        // randomSaikoro >= 1   randomSaikoro変数の値が、1以上である場合、真（true）となる.
    }
}
