using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList;
using UnityEngine;
using UnityEngine.EventSystems;

public class animee : MonoBehaviour

{
    public Rigidbody2D Pl;
    public Animator anim;
    public LayerMask ground;
    public Collider2D coll;
    private PlayerMove Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Pl").GetComponent<PlayerMove>();
    }

    void Swichanim()
    {
        anim.SetBool("idle", false);
        if (anim.GetBool("jumping"))
        {
            if (Pl.velocity.y < 0)
            {
                anim.SetBool("jumping", false);     //下落动画
                anim.SetBool("downing", true);
            }
        }
        else if (coll.IsTouchingLayers(ground))
        {
            anim.SetBool("downing", false);       //下落完成
            anim.SetBool("idle", true);
        }

    }


    // Update is called once per frame
    void Update()
    {

        Movinganime();
        Swichanim();

    }

    void Movinganime()
    {
        float HorizontalMove2 = Input.GetAxis("Horizontal");

        if (HorizontalMove2 != 0)
        {
            anim.SetFloat("running", Mathf.Abs(HorizontalMove2));   //跑步动画播放
        }

        if (Input.GetButtonDown("Jump"))
        {
            anim.SetBool("jumping", true);      //跳跃动画播放
        }


    }

}
