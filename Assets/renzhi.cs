using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class renzhi : MonoBehaviour
{

    public Animator anim;
    private float timer = 0;
    private bool isis = false;
    private bool collection = false;
    public GameObject gem;
    public Transform nnnn;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "bullet")
        {
            anim.SetTrigger("help");
            isis = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isis)
        {
            timer +=Time.deltaTime;
            if (timer > 1.3f)
            {
                if (!collection)
                {
                    Instantiate(gem, nnnn.position, nnnn.rotation);
                    collection = true;
                }
                
                anim.SetTrigger("runaa");
                
            }
            if (timer > 1.7)
            {
                transform.Translate(Time.deltaTime * -5, 0, 0);
            }
            if (timer > 8)
            {
                Destroy(gameObject);
            }

        }
    }
}
