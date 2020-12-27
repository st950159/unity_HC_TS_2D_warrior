using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//標題 Header
//提示 Tooltip
//範圍 Range


public class Car : MonoBehaviour
{
    #region 標題練習

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

    //遊戲物件 與 元件
    //遊戲物件:儲存階層面板內的物件與預製物
    public GameObject objA;
    public GameObject objB;


    //元件:屬性面板上可摺疊的元件
    public Transform tra;
    public Camera cam;

    #endregion

#region 方法練習
    
    //欄位語法
    //修飾詞 類型 名稱 () { 程式區塊.陳述式.演算法 }

    //void 無回傳:呼叫此方法後不會回傳任何資料
    //自訂方法
    //不會執行.必須要呼叫才會執行

    private void Test()
    {
        //輸出 方法
        print("哭阿~");

    }

    private int Ten()
    {
        return 10;
    }

    private float OnePointFive()
    {
        return 1.5f;
    }

    private string Name()
    {
        return "K";
    }

    /// <summary>
    /// 開車
    /// </summary>
    /// <param name="direction">方向</param>
    /// <param name="sound">聲音</param>
    /// <param name="speed">速度</param>
    private void Drive(string direction,string sound,int speed)
    {
        print("開車方向:" + direction);
        print("開車音效:" + sound);
        print("速度:" + speed);

    }

    /// <summary>
    /// 雨刷
    /// </summary>
    /// <param name="speed"></param>
    /// 參數預設值
    /// 選填式參數一定要放在最右邊
    private void OpneBrush(string sound,int count = 2,int speed = 50)
    {
        print("開雨刷");
        print("雨刷音效:" + sound);
        print("雨刷速度:" + speed);
        print("雨刷數量:" + count);
    }
    #endregion


    //名稱藍色:事件
    //在特定時間點會執行的方法
    //開始事件:遊戲開始時會執行一次
    private void Start()
    {
#region 練習:欄位取得與設定

        //使用欄位
        //取得Get
        print("品牌:" + brand);
        print("高度:" + height);

        //設定 set
        hasWindow = false;
        weight = 5.5f;


        // 呼叫方法
        // 方法名稱
        Test();

        //傳回方法使用方法
        //1. 直接當作傳回類型使用

        print("傳回的整數:" + Ten());
        print("傳回的浮點數:" + OnePointFive());

        //2. 儲存在區域變數內
        //區域變數:在事件或方法內可使用的欄位
        //僅限於此括號內使用
        string myName = Name();
        print(myName);

        Drive("往後開", "噗", 30);
        Drive("往前開", "噗", 50);
        Drive("往前開", "轟巄巄巄", 300);

        OpneBrush("刷");
        OpneBrush("刷刷",speed: 500);


        #endregion
    }




}

