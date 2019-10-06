using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOutInSText : MonoBehaviour
{
    public float FadeRate;
    private UnityEngine.UI.Text text;
    private float targetAlpha;
    // Use this for initialization
    void Start()
    {
        this.text = this.GetComponent<Text>();
        if (this.text == null)
        {
            Debug.LogError("Error: No Text on " + this.name);
        }
        this.targetAlpha = this.text.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        Color curColor = this.text.color;
        float alphaDiff = Mathf.Abs(curColor.a - this.targetAlpha);
        if (alphaDiff > 0.0001f)
        {
            curColor.a = Mathf.Lerp(curColor.a, targetAlpha, this.FadeRate * Time.deltaTime);
            this.text.color = curColor;
        }
    }

    public void FadeOut()
    {
        this.targetAlpha = 0.0f;
    }

    public void FadeIn()
    {
        this.targetAlpha = 1.0f;
    }
}
