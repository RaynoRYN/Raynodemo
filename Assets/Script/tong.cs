using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tong : MonoBehaviour
{

    public int hp = 6;
    public Animator anim;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "bullet")
        {
            hp--;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp < 4)
        {
            anim.SetTrigger("break");
        }
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
