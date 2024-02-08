using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine;

public class PointsUI : MonoBehaviour
{
    private Points points;
    public TMP_Text text;

    void Start()
    {
        text = GetComponent<TMP_Text>();
        points = GameObject.FindGameObjectWithTag("Player").GetComponent<Points>();
        
    }

    void Update()
    {
        int p = points.Point;
        text.text = "Points : " + p;
    }
}
