using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProgressBarS : MonoBehaviour
{
    private Slider xpbar;

    public float FillSpeed = 10f;
    private float totalxp = 0;
    
    private void Awake()
    {
        xpbar = gameObject.GetComponent<Slider>();
    }

    // Start is called before the first frame update
    void Start()
    {
        XPProgress(100f);
    }

    // Update is called once per frame
    void Update()
    {
        if (xpbar.value < totalxp)
            xpbar.value = Mathf.Lerp(xpbar.value, totalxp , Time.deltaTime * FillSpeed);
    }
    public void XPProgress(float gainedxp)
    {
    totalxp = xpbar.value + gainedxp;
        }
}
