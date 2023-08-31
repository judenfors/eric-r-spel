using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cash : MonoBehaviour
{

    float time = 0;
    void Update(){
        float startYPos = 1.5f;
        float yPos = startYPos + (float)Math.Sin(time);
        Vector3 position = transform.position;
        position.y = yPos;
        transform.position = position;
    }
    void OnTriggerEnter(Collider other) {
        if(other.tag=="Player"){
            other.GetComponent<Points>().AddPoints(1);
            Destroy(gameObject);
        }
    }
}
