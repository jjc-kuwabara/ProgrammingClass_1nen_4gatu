using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kadai_4 : MonoBehaviour
{
    void Start()
    {
        // 文字列（String）を格納するための、string型の変数を宣言する.
        // 型名の後ろに[]を付けると、「配列」を宣言していることになります.
        // 配列は、値を格納するための変数が、複数個存在している場合に活用します.
        string[] legendName;

        // 配列を宣言した場合、必ず、何個の要素を持った配列なのか、宣言する必要があります.
        legendName = new string[6];

        // それぞれの要素に対して、値を格納することができます.
        legendName[0] = "ブラッドハウンド";
        legendName[1] = "ジブラルタル";
        legendName[2] = "ライフライン";
        legendName[3] = "パスファインダー";
        legendName[4] = "レイス";
        legendName[5] = "バンガロール";

        // 繰り返し処理を用いることで、配列の各要素に対してアクセス出来ます.
        Debug.Log("最初から使用可能なレジェンドは次の通りです.");
        for (int i = 0; i < 6; i++)
        {
            Debug.Log(legendName[i]);
        }

        ///////////////////////////////// 課題 //////////////////////////////////////////////////
        // Apex Legendsのレジェンド、総勢23名の名前を表示してください.

        string[] allLegendName;

        allLegendName = new string[1];

        allLegendName[0] = "未設定";


        // 繰り返し処理を用いることで、配列の各要素に対してアクセス出来ます.
        Debug.Log("全てのチャンピオンは次の通りです.");
        for (int i = 0; i < 1; i++)
        {
            Debug.Log(allLegendName[i]);
        }
    }

}
