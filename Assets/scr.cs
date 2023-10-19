using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
{
    public Rigidbody myrig;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)==true){
            myrig.velocity = Vector3.up * speed;
        }
        if(Input.GetKeyDown(KeyCode.A)==true){
            myrig.velocity = Vector3.left * speed;
        }
        if(Input.GetKeyDown(KeyCode.D)==true){
            myrig.velocity = Vector3.right * speed;
        }
        if(Input.GetKeyDown(KeyCode.S)==true){
            myrig.velocity = Vector3.down * speed;
        }
        while(Input.GetKeyDown(KeyCode.Q)==true){
            myrig.velocity = Vector3.zero;
        }
    }
}
