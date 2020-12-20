using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//標題 Header
//提示 Tooltip
//範圍 Range


public class Car : MonoBehaviour
{
    [Header("這是汽車的高度"), Range(1,10)]
   public int height =5;               //高度
    [Tooltip("這是汽車的重量，單位是噸"), Range(2.5f,10.5f)]
   public float weight =5.5f;          //重量
    [Header("這是汽車的品牌")]
   public string brand ="BMW";         //品牌
    [Header("汽車是否有天窗")]
    public bool hasWindow = true;       //是否有天窗
    
    //其他類型
    //顏色
    public Color myColor;
    public Color red = Color.red;
    public Color blue = Color.blue;
    public Color myColor1 = new Color(0f, 0.6f, 0.9f);

    //座標 向量 2 - 4
    public Vector2 v2zero = Vector2.zero;
    public Vector2 v2one = Vector2.one;
    public Vector2 v2A = new Vector2(9, 10);

    public Vector3 v3A = new Vector3(1, 2, 3);
    public Vector4 v4A = new Vector4(1, 2, 3, 4);

    //音樂 音效
    public Sprite plcture;
    public AudioClip sound;




}

