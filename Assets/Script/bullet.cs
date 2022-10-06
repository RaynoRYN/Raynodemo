using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float dir = 1;//·½Ïò


    void Start()
    {
        Destroy(gameObject,3f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Pl" || collision.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.right * 5 * Time.deltaTime * (dir > 0 ? 1 : -1));
        
    }
}
