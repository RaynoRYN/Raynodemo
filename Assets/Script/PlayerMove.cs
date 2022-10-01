using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
    public Rigidbody2D Pl;
    public float speed;
    public float jumpforce;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Jumpp()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Pl.velocity = new Vector2(Pl.velocity.x, jumpforce);  //实现跳跃
        }
    }
    void Update()
    {
        Jumpp();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();

    }
    

    void Movement()
    {

        float HorizontalMove = Input.GetAxis("Horizontal");  //获得水平方向按键+1或-1
        double Faceddir = Input.GetAxisRaw("Horizontal");   //朝向

        if(HorizontalMove != 0)
        {
            Pl.velocity = new Vector2(HorizontalMove * speed*Time.deltaTime , Pl.velocity.y);  //实现移动
        }

        if (Faceddir != 0)
        {
            transform.localScale = new Vector3((float)Faceddir,1, 1);    //实现转向
        }


    }




}
