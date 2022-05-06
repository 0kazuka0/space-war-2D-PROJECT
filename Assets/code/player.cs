using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 10f;
    public float rotspeed = 180f;



    float shipradius = 0.5f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rota = transform.rotation;
        float z = rota.eulerAngles.z;//เปลี่ยนเเกนzเป็นbase input
        z -= Input.GetAxis("Horizontal") * rotspeed * Time.deltaTime;//หมุน
        rota = Quaternion.Euler(0, 0, z);

        transform.rotation = rota;//ป้อนquaternionเป็นหมุน
        //เคลื่อนที่
        Vector3 posi = transform.position;
        Vector3 velocity = new Vector3(0,Input.GetAxis("Vertical") * speed * Time.deltaTime,0);//ขึ้น ลง พุ่ง ถอย
        posi += rota * velocity;
        //playerไม่หลุดฉาก
        if(posi.y+shipradius>Camera.main.orthographicSize)
        {
            posi.y = Camera.main.orthographicSize-shipradius;
        }
        if (posi.y - shipradius < -Camera.main.orthographicSize)
        {
            posi.y = -Camera.main.orthographicSize + shipradius;
        }
        float screenrati = (float)Screen.width / (float)Screen.height;
        float widthortho = Camera.main.orthographicSize * screenrati;
        if (posi.x + shipradius > widthortho)
        {
            posi.x = widthortho - shipradius;
        }
        if (posi.x - shipradius < -widthortho)
        {
            posi.x = -widthortho + shipradius;
        }
        //การเคลื่อนที่จะถูกอัพเดทตลอด
        transform.position = posi;
    }
}
