using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Coinmanager : MonoBehaviour
{
    public GameObject prefab;
    public GameObject cash;

    void Start(){
        cash = GameObject.FindGameObjectWithTag("Coin");
    }

    void Update()
    {
        if(cash == null) {
            SpawnCoin();
        }
    }

    private void SpawnCoin(){
        float x = Random.Range(-10f,10f);
        float z = Random.Range(-10f,10f);
        Vector3 position = new Vector3(x,1.5f,z);

        cash = Instantiate(prefab);
        cash.transform.position = position;
    }
}
