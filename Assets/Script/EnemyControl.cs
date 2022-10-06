using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{

    private int hp = 1;
    private Animator anim;
    private PlayerMove Pl;   //获得玩家信息
    private float timer = 0;
    private float timer2 = 0;
    public GameObject Bullet;
    public Transform FirePoint;
    void Start()
    {
        anim = GetComponent<Animator>();
        Pl = GameObject.FindWithTag("Pl").GetComponent<PlayerMove>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "bullet")
        {
            hp--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (hp <= 0)
        {
            timer = 0;
            anim.SetTrigger("die");
            timer2+=Time.deltaTime;
            if (timer2 > 1.1f)
            {
                Destroy(gameObject);
            }
        }
        //和玩家的距离
        float dis=Vector3.Distance(Pl.transform.position,transform.position);
        if (dis < 4&& timer > 3f)
        {
            Instantiate(Bullet, FirePoint.position, FirePoint.rotation).GetComponent<bullet>().dir = transform.localScale.x * -1;
            timer = 0;
        }
        
    }
}
