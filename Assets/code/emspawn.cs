using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emspawn : MonoBehaviour
{
    public GameObject enemypref;
    public float spawndis = 20f;
    public float enemyincom = 5;
    public float nextenemy = 1;
    void Update()
    {
        nextenemy -= Time.deltaTime;
        if (nextenemy <= 0)
        {
            nextenemy = enemyincom;
            enemyincom *= 0.7f;
            if(enemyincom<5)
            {
                enemyincom = 1;
            }

            Vector3 offset = Random.onUnitSphere;
            offset.z = 0;
            offset = offset.normalized * spawndis;
            Instantiate(enemypref, transform.position + offset, Quaternion.identity);
        }
    }
}
