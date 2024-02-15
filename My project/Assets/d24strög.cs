using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class d24strög : MonoBehaviour
{
    public float speed = 2f;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            transform.position += new Vector3(0,0,speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.S)){
            transform.position += new Vector3(0,0,-speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.A)){
            transform.position += new Vector3(-speed * Time.deltaTime,0,0);
        }

        if(Input.GetKey(KeyCode.D)){
            transform.position += new Vector3(speed * Time.deltaTime,0,0);
        }
    }
}
