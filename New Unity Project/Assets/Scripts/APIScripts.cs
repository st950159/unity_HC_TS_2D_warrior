using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 認識API 靜態 Static
/// </summary>
public class API : MonoBehaviour
{
    private void Start()
    {
        #region 靜態屬性存取
        //屬性
        //取得靜態屬性
        //語法 :
        //類別名稱.靜態屬性
        print("隨機值:" + Random.value);
        print("拍:" + Mathf.PI);

        //設定 靜態屬性
        //語法 :
        //類別名稱.靜態屬性 = 值;
        Cursor.visible = false;
        

        //如果有 Read Only 不能設定 - 唯讀
        //Time.deltaTime = 0.5f; // 錯誤

        //時間.尺寸 = 2 倍速

        Time.deltaTime = 2;
        #endregion

        //靜態方法
        //語法:
        //類別名稱.靜態方法(對應引數);
        print("隨機值介於 100 - 500:" + Random.Range(100, 500));

        int number = Mathf.Abs(-99);
        print("取完絕對值的整數:" + number);

    }




}
