using UnityEngine;
using UnityEngine.UI;           //引用 介面 API


//第一次套用腳本時執行
//添加元件(類型(元件)，類型(元件))
[RequireComponent(typeof(AudioSource), typeof(Rigidbody2D), typeof(CapsuleCollider2D))]
public class enemy : MonoBehaviour
{
   
    [Header("攻擊距離"), Range(0, 100)]
    public float rangeATK = 10;
    [Header("移動速度"), Range(0, 1000)]
    public float speed = 10;
    [Header("攻擊力"), Range(0, 1000)]
    public float ATK = 100;
    [Header("血量"), Range(0, 5000)]
    public float hp = 2500;
    [Header("血量文字")]
    public Text textHp;
    [Header("血量圖片")]
    public Image imgHp;


    private Animator ani;
    private AudioSource aud;
    private Rigidbody2D rig;
    private float hpMax;
    private Player player;

    private void Start()
    {
        ani = GetComponent<Animator>();
        aud = GetComponent<AudioSource>();
        rig = GetComponent<Rigidbody2D>();
        hpMax = hp;
        player = FindObjectOfType<Player>();    //透過類行尋找物件<類型>() - 不能是重複物件
    }
    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="damage"></param>
    public void Damage(float damage)
    {
        hp -= damage;                   //遞減
        ani.SetTrigger("受傷");         //受傷動畫
        textHp.text = hp.ToString();    //血量文字.文字內容 = 血量.轉字串()
        imgHp.fillAmount = hp / hpMax;  //血量圖片.填滿長度 = 目前血量 / 最大血量

        if (hp <= 0) Dead();
    }

    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {
        hp = 0;
        textHp.text = 0.ToString();
        ani.SetBool("死亡", true);
        //取得元件<膠囊碰撞>().啟動 = 關閉
        GetComponent<CapsuleCollider2D>().enabled = false;
    }

    /// <summary>
    /// 追蹤玩家與面向玩家
    /// </summary>
    private void Move()
    {
        /** 判斷式寫法
        if (transform.position.x > player.transform.position.x)
        {
            transform.eulerAngles = new Vector3(0, 100, 0);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        */

        // y = x 是否大於 玩家 x ? 是 y 為 180 : 否 y 為 0
        float y = transform.position.x > player.transform.position.x ? 180 : 0;
        transform.eulerAngles = new Vector3(0, y, 0);
    }



}
