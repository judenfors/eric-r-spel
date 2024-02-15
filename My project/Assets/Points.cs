using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class Points : MonoBehaviour
{

    private int points = 0; 

    public int Point{
        get{return points;}
        set{points = value;}
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
