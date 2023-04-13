using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kadai_5 : MonoBehaviour
{
    void Start()
    {
        // 文字列（String）を格納するための、string型の変数を宣言する.
        // 型名の後ろに[]を付けると、「配列」を宣言していることになります.
        // 配列は、値を格納するための変数が、複数個存在している場合に活用します.
        string[] talentName;

        // 配列を宣言した場合、必ず、何個の要素を持った配列なのか、宣言する必要があります.
        talentName = new string[4];

        // それぞれの要素に対して、値を格納することができます.
        talentName[0] = "兎田ぺこら";
        talentName[1] = "不知火フレア";
        talentName[2] = "白銀ノエル";
        talentName[3] = "宝鐘マリン";

        // 文字列（Integer）を格納するための、int型の変数を宣言する.
        // 型名の後ろに[]を付けると、「配列」を宣言していることになります.
        // 配列は、値を格納するための変数が、複数個存在している場合に活用します.
        int[] talentSaikoro;
        talentSaikoro = new int[4];

        // 1から6までの値を出す乱数を使って、サイコロの目を指定する.
        talentSaikoro[0] = Random.Range(1, 6 + 1);
        talentSaikoro[1] = Random.Range(1, 6 + 1);
        talentSaikoro[2] = Random.Range(1, 6 + 1);
        talentSaikoro[3] = Random.Range(1, 6 + 1);


        // 繰り返し処理を用いることで、配列の各要素に対してアクセス出来ます.
        Debug.Log("ホロライブ３期生の皆さんのサイコロの目は次の通りです.");
        for (int i = 0; i < 4; i++)
        {
            Debug.Log(talentName[i] + "さんのサイコロの目は" + talentSaikoro[i].ToString());
        }

        ///////////////////////////////// 課題 //////////////////////////////////////////////////
        // 最もサイコロの目が大きい人、１名の名前を表示してください.

        // 最も大きいサイコロの目を保存する.
        int maxSaikoroValue = 0;
        // 最もサイコロの目が大きかったタレントのIDを保存する.
        int maxSaikoroTalentId = 0;
        for (int i = 0; i < 4; i++)
        {
            // if文を用いて判定を行ってください.
        }

        Debug.Log("出目が一番大きかった人は" + talentName[maxSaikoroTalentId] + "さんで、その目は" + talentSaikoro[maxSaikoroTalentId] + "です.");
    }
}
