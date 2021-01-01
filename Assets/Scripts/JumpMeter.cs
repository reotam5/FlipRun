using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMeter : MonoBehaviour
{
    public Variables var;
    public Material red;
    public Material green;
    public Material yellow;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(var.JumpMeterSizeX, var.JumpMeterSizeY, 1f);
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(0f + var.JumpMeterWidth, Screen.height - (var.JumpMeterHeight/1.5f), 5f));

        for (int i = gameObject.transform.childCount-1; i >= 0; i--)
        {
            if (gameObject.transform.GetChild(i).name == "WhiteFrame")
            {
                gameObject.transform.GetChild(i).transform.localScale = new Vector3(0.8f,0.95f,1f);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (var.currentCharge > var.charge)
        {
            var.currentCharge = var.charge;            
        }

    }
    void FixedUpdate()
    {
        if (var.currentCharge < var.charge)
        {
            var.currentCharge = var.currentCharge + var.increament * Time.deltaTime;
        }
        for (int i = gameObject.transform.childCount - 1; i >= 0; i--)
        {
            if (gameObject.transform.GetChild(i).name == "Meter")
            {
                gameObject.transform.GetChild(i).transform.localScale = new Vector3(0.8f, 0.95f * var.currentCharge / var.charge, 1f);
                gameObject.transform.GetChild(i).transform.localPosition = new Vector3(0f, -0.5f*0.95f+(0.95f * var.currentCharge / var.charge)/2f, -2f);


                if (var.currentCharge / var.charge >= 2f / 3f)
                {
                    gameObject.transform.GetChild(i).gameObject.GetComponent<MeshRenderer>().material = green;
                }
                else if (var.currentCharge / var.charge >= 1f / 3f)
                {
                    gameObject.transform.GetChild(i).gameObject.GetComponent<MeshRenderer>().material = yellow;
                }
                else
                {
                    gameObject.transform.GetChild(i).gameObject.GetComponent<MeshRenderer>().material = red;
                }
            }
        }
    }
}
