using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mode : MonoBehaviour
{
    public void next1()
    {
        SceneManager.LoadScene("menu");
    }

    public void next2()
    {
        SceneManager.LoadScene("2");
    }
    public void next3()
    {
        SceneManager.LoadScene("3");
    }
}
