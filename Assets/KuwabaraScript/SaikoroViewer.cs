using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaikoroViewer : MonoBehaviour
{
    Image img;
    private void Awake()
    {
        img = GetComponent<Image>();
    }

    public void SetSaikoro(int saikoro)
    {
        img.sprite = Resources.Load<Sprite>("Saikoro/saikoro_" + saikoro.ToString());
    }
}
