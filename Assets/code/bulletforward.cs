using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletforward : MonoBehaviour
{
    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        Vector3 posi = transform.position;
        Vector3 velocity = new Vector3( 0,speed * Time.deltaTime, 0);
        posi += transform.rotation * velocity;
        transform.position = posi;
    }
}
