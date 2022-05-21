using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataAsText : MonoBehaviour
{
    public Text text1;

    void Start()
    {
        text1.color = new Color32(0, 0, 0, 255);
        text1.text = "" + GameObject.Find("Initialize").GetComponent<Memory>().researchPoints;
    }
    
    void Update()
    {
        text1.text = "" + GameObject.Find("Initialize").GetComponent<Memory>().researchPoints;
    }
}
