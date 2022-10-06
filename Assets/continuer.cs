using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class continuer : MonoBehaviour
{
    public void OnMouseUpAsButton()
    {
        SceneManager.LoadScene("Level1");
    }
}
