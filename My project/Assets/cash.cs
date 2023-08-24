using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cash : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if(other.tag=="Player"){
            Destroy(gameObject);
        }
    }
}
