using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public Boolean forward = true;
    public Boolean down = true;
    public Boolean jumping;
    public Boolean FlipGravity;
    public float gravityScale = 5;
    public float ScreenWidth;
    public float ScreenHeight;
    public float JumpMeterWidth;
    public float JumpMeterHeight;
    public float JumpMeterSizeX;
    public float JumpMeterSizeY;
    public float Scale; //multiply this with screen size to get local size
    public float charge = 6;
    public float currentCharge = 6;
    public float increament = 0.5f;
    public float speed = 4.5f;
    public float jumpforce = 17f;
    public Vector3 StartPos = new Vector3(-7.5f,-2.5f,0f);
    public string CurrentStage = "Stage1";
    void Awake()
    {
        ScreenWidth = Screen.width;
        ScreenHeight = Screen.height;
        Vector3 temp = Camera.main.ScreenToWorldPoint(new Vector3(ScreenWidth, ScreenHeight, 1f));
        Vector3 temp2 = Camera.main.ScreenToWorldPoint(new Vector3(0f,0f, 1f));
        JumpMeterWidth = ScreenWidth / 20;
        JumpMeterHeight = ScreenHeight / 3;
        JumpMeterSizeX = Mathf.Abs(temp.x - temp2.x)/20;
        JumpMeterSizeY = Mathf.Abs(temp.y - temp2.y)/3;

        Scale = JumpMeterSizeX / JumpMeterWidth;


    }
}
