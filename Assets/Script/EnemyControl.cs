using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{

    private int hp = 1;
    private bool isshow = false;
    private Animator anim;
    private PlayerMove Pl;   //��������Ϣ
    private float timer = 0;
    void Start()
    {
        anim = GetComponent<Animator>();
        Pl = GameObject.FindWithTag("Pl").GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0) return;
        //����ҵľ���
        float dis=Vector3.Distance(Pl.transform.position,transform.position);
        
    }
}
