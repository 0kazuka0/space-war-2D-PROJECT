using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai : MonoBehaviour
{
    public float rotaspeed = 180f; 
    Transform player;
    // Update is called once per frame
    void Update()
    {
        if(player==null)
        {
            GameObject follow = GameObject.Find("player");
            if(follow!=null)
            {
                player = follow.transform;
            }
        }
        if (player == null)
            return;
        Vector3 direct = player.position - transform.position;
        direct.Normalize();

        float zAngle = Mathf.Atan2(direct.y, direct.x) * Mathf.Rad2Deg - 90;
        Quaternion desiredrota = Quaternion.Euler(0, 0, zAngle);
        transform.rotation=Quaternion.RotateTowards(transform.rotation, desiredrota, rotaspeed * Time.deltaTime);
    }
}
