// ここは、プログラムのソースコードを記入するための、.csファイルです。csは、C-Sharp（C#）の意味です.
// このcsファイルに、プログラミング言語C#の文法に沿った文字列を打ち込むことで、プログラムが意図通りに動きます.
// 「//」を記入した場所から、後ろは、改行するまで、コメントとして扱われます.
// コメントは、ソースコードと解釈されず、無視されます.

/*
 　このように記入することで、1行分ではなく、複数行のコメントを作ることも出来ます.
 */

// この下の部分、usingと書いてあるのは、プログラミング言語C#や、ゲームエンジンUnityが提供している、様々な機能を使いたいです、とお願いをしています.
// 「System」という枠組みの中に存在する、「Collections」という枠組みの中にある処理を全部使いたいです。とお願いをしています.
// 以下同様に、「Generic」という枠組みの中の処理を使いたい、「UnityEngine」という枠組みの中の処理を使いたい、「UI」という枠組みの中の処理を使いたい、とお願いをしています.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ここから、プログラムの具体的な処理を記載します.
// ここでは、「Kadai1」という名前のクラス（Class）の宣言を行っています.
// クラスは、パラメータや、計算処理を、分かりやすく納めておくための箱です.
// Unityの決まりとして、必ず、ソースコードのファイル名と一致した名前のクラスを宣言する必要があります.
public class Kadai_1 : MonoBehaviour
{
    // Start関数は、プログラムが起動してから、1回だけ呼び出す処理です.
    void Start()
    {
        timerSinceGamePlay = 0.0f;
        Debug.Log("Start関数を呼びました. ゲーム起動から経過した時間は" + timerSinceGamePlay.ToString() + "秒です.");
    }

    // Update関数は、プログラムが起動して、Start関数の実行が完了した後に、毎フレーム呼び出す処理です.
    void Update()
    {
        timerSinceGamePlay = timerSinceGamePlay + Time.deltaTime; // 前回の起動時から経過した秒数を加算しています.
        Debug.Log(Time.frameCount.ToString() + "フレーム目のUpdate関数を呼びました.  ゲーム起動から経過した時間は" + timerSinceGamePlay.ToString() + "秒です.");
    }

    float timerSinceGamePlay; // ゲーム起動から経過した時間（秒数）.
}
