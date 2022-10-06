using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{

    public void OnMouseUpAsButton()
    {
            SceneManager.LoadScene("Level1");
    }


}
