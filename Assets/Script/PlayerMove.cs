using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class PlayerMove : MonoBehaviour
{
    
    public Rigidbody2D Pl;
    public float speed;
    public float jumpforce;
    public LayerMask ground;
    public Collider2D coll;
    public Animator anim;
    public int Points;
    public TextMeshProUGUI Num;
    public GameObject Bullet;
    public Transform FirePoint;
    public float timer = 0;
    public float timer2 = 0;
    private bool Live = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Jumpp()
    {
        if (Input.GetButtonDown("Jump")&& coll.IsTouchingLayers(ground))
        {   
            Pl.velocity = new Vector2(Pl.velocity.x, jumpforce);  //实现跳跃
            
        }
    }

    void Swichanim()
    {   
        anim.SetBool("idle", false);

        if (coll.IsTouchingLayers(ground))
        {       
            anim.SetBool("idle", true);         //下落完成
        }

    }

    void Attacking()
    {
        
        if (timer > 0.6f)
        {
            
            if (Input.GetKeyDown(KeyCode.J))
            {   
                timer = 0;
                anim.SetTrigger("attack");
                Instantiate(Bullet, FirePoint.position, FirePoint.rotation).GetComponent<bullet>().dir=transform.localScale.x;  //生成子弹确认方向
            }

        }
    }


    //收集
    private void OnTriggerEnter2D(Collider2D collision)    
    {
        if (collision.tag == "collection")
        {
            Destroy(collision.gameObject);
            Points += 100;
            Num.text =Points.ToString();
        }
        
        if(collision.tag == "bullet")
        {
            Live = false;
            timer = 0;
            anim.SetTrigger("die");
            GameObject.FindGameObjectWithTag("legs").GetComponent<animee>().anim.SetTrigger("Die");
            
        }
    }

 
   

    void Update()
    {
        if (Live)
        {
            timer += Time.deltaTime;
            Jumpp();
            Swichanim();
            Attacking();
        }
        else
        {
            timer2 += Time.deltaTime;
            if (timer2 > 1.1f)
            {
                Live = true;
                timer2 = 0;
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Live)
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
