using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JJC : MonoBehaviour
{
    public static void SetSaikoro(int saikoro)
    {
        GameObject.Find("SaikoroViewer").GetComponent<SaikoroViewer>().SetSaikoro(saikoro);
    }

    public static void SetPlayerSaikoro(int saikoro)
    {
        GameObject playerObject = GameObject.Find("PlayerSaikoro");
        GameObject saikoroViewer = playerObject.transform.Find("SaikoroViewer").gameObject;
        saikoroViewer.GetComponent<SaikoroViewer>().SetSaikoro(saikoro);
    }
    public static void SetEnemySaikoro(int saikoro)
    {
        GameObject.Find("EnemySaikoro").transform.Find("SaikoroViewer").GetComponent<SaikoroViewer>().SetSaikoro(saikoro);
    }

    public static void KickPopUpMsgBox(string str)
    {
        GameObject.Find("PopUpMsgBox").GetComponent<PopUpMover>().Kick(str);
    }
}
