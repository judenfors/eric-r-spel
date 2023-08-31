using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{

    private int points = 0; 

    public int Point{
        get{return points;}
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void AddPoints(int points){
        this.points += points;
    }
}
