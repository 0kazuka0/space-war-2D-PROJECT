using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class damagep : MonoBehaviour
{
    public int hp = 1;//เลือด
    
    public float freeperiod = 0;
    float freetime = 0;
    int correctlayer;

    
    // Start is called before the first frame update
    private void Start()
    {
        correctlayer = gameObject.layer;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        hp--;
        freetime = freeperiod;//เวลาdelayโดนdmg
        gameObject.layer = 10;

    }
    void Update()
    {
        freetime -= Time.deltaTime;
        if (freetime <= 0)
        {
            gameObject.layer = correctlayer;
        }
        if (hp <= 0)
        {
            
            dead();
            SceneManager.LoadScene(0);
        }
        
    }
    void dead()
    {
        Destroy(gameObject);
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 100, 50), "HP=" + hp);
        
    }
}