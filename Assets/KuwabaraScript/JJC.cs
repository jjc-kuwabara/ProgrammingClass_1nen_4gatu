using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public static void SetSaikoro(int id, int saikoro)
    {
        GameObject.Find("TalentViewer" + id.ToString() + "/SaikoroViewer").GetComponent<SaikoroViewer>().SetSaikoro(saikoro);
    }
    public static void SetTalentName(int id, string name)
    {
        GameObject.Find("TalentViewer" + id.ToString() + "/Name").GetComponent<Text>().text = name;
    }
    public static void KickPopUpMsgBox(string str)
    {
        GameObject.Find("PopUpMsgBox").GetComponent<PopUpMover>().Kick(str);
    }
}
