using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpMover : MonoBehaviour
{
    GameObject popUp;
    Text text;
    Image img;
    float alpha;

    private void Awake()
    {
        text = transform.Find("Text").GetComponent<Text>();
        img = transform.Find("BackGround").GetComponent<Image>();
        SetAlpha(0.0f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (alpha > 0.0f)
        {
            alpha -= 1.0f * Time.deltaTime;
        }
        else
        {
            alpha = 0.0f;
        }
        SetAlpha(alpha);

    }

    public void Kick(string str)
    {
        text.text = str;
        alpha = 1.0f;
    }

    void SetAlpha(float alpha)
    {
        text.color = new Color(text.color.r, text.color.g, text.color.b, alpha);
        img.color = new Color(img.color.r, img.color.g, img.color.b, alpha);
    }
}
