using UnityEngine;

public class Door : MonoBehaviour
{
    [Header("鑰匙")]
    public GameObject key;

    private Animator ani;

    private void Start()
    {
        ani = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //如果 玩家進入 並且 鑰匙 已被吃掉 就開門
        if (collision.name == "主角" && key == null)
        {
            ani.SetTrigger("開門");
        }
    }
}
