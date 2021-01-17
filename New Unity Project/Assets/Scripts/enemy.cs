using UnityEngine;

//第一次套用腳本時執行
//添加元件(類型(元件)，類型(元件))
[RequireComponent(typeof(AudioSource), typeof(Rigidbody2D), typeof(CapsuleCollider2D))]
public class enemy : MonoBehaviour
{
    [Header("血量"), Range(0, 5000)]
    public float HP = 5000;
    [Header("攻擊距離"), Range(0, 100)]
    public float rangeATK = 10;
    [Header("移動速度"), Range(0, 1000)]
    public float speed = 10;
    [Header("攻擊力"), Range(0, 1000)]
    public float ATK = 100;


    private Animator ani;
    private AudioSource aud;
    private Rigidbody2D rig;

    private void Start()
    {
        ani = GetComponent<Animator>();
        aud = GetComponent<AudioSource>();
        rig = GetComponent<Rigidbody2D>();
    }

    public void Damage(float damage)
    {
        HP -= damage;                 //遞減
        ani.SetTrigger("受傷");       //受傷動畫
    }
}
