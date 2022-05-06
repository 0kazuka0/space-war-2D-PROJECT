using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnStartButton()
    {
        SceneManager.LoadScene("mode");
    }

    public void OnExitButton()
    {
        Application.Quit();
    }
}