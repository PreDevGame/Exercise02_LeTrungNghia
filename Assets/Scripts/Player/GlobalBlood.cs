using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBlood : MonoBehaviour
{
    public GameObject healthDisplay;
    public static int healthValue;
    public int internalHealth;

    void Start()
    {
        healthValue = 100;
    }

    void Update()
    {
        internalHealth = healthValue;
        healthDisplay.GetComponent<Text>().text = "" + healthValue;
    }
}
