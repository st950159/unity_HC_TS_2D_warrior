using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位

    [Header("移動速度"), Range(0, 1000)]
    public float speed = 10.5f;
    [Header("跳越高度"), Range(0, 3000)]
    public int jump = 100;
    [Header("是否在地板上"), Tooltip("判斷角色是否在地板上")]
    public bool isGrounded;
    [Header("子彈")]
    public GameObject bullet;
    [Header("子彈生成點")]
    public Transform pointSpawn;
    [Header("子彈速度")]
    public int speedBullet = 800;
    [Header("開槍音效")]
    public AudioClip soundFire;
    [Header("血量"), Range(0, 2000)]
    public float hp = 100;

    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;

    #endregion

    /// <summary>
    /// 取得玩家水平軸向的值
    /// </summary>
    float h;

    private void Start()
    {
        // GetComponent<泛型>()
        //泛型:泛指所有類型
        // GetComponent<AudioSource>()
        // GetComponent<Animator>()


        // 剛體欄位 = 取得元件<剛體>()
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        GetHorizontal();
        Move();
    }


    #region 方法
    /// <summary>
    /// 取得水平軸向
    /// </summary>
    private void GetHorizontal()
    {
        // 輸入.取得軸向("水平")
        h = Input.GetAxis("Horizontal");
    }



    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        // 剛體.加速度 = 二維(水平 * 速度,原本加速度的 Y)
        rig.velocity = new Vector2(h * speed, rig.velocity.y);

        //如果 玩家 按下 D 就執行 ( 內容 )
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Transform 指的與此腳本是同一層的 Transform 元件
            //Rotation 角度是程式是 localEulerAngles
            transform.localEulerAngles = Vector3.zero;
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.localEulerAngles = new Vector3(0, 180, 0);
        }




    }



    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {

    }



    /// <summary>
    ///開火 
    /// </summary>
    private void Fire()
    {

    }

    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="getDamage"></param>
    private void Damage(float getDamage)
    {


    }


    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {

    }

    #endregion
}
