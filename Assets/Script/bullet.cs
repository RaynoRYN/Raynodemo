using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float dir = 1;//����


    void Start()
    {
        Destroy(gameObject,3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.right * 5 * Time.deltaTime * (dir > 0 ? 1 : -1));
    }
}
