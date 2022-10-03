using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{

    public Transform Pl;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Pl.position.x+1,-4,-10);  //¾µÍ·¸ú×Ù
    }
}
