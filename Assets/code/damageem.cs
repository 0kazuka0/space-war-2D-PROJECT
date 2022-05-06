using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageem : MonoBehaviour
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
        }
    }
    void dead()
    {
        Destroy(gameObject);
    }
    
}
