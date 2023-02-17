using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBlood : MonoBehaviour
{
    public GameObject healthDisplay;
    public static int healthValue;
    public int internalHealth;
    public GameObject bloodBarUI;

    void Start()
    {
        healthValue = 100;
    }

    void Update()
    {
        if(healthValue > 100)
        {
            healthValue = 100;
        }
        internalHealth = healthValue;
        healthDisplay.GetComponent<Text>().text = "" + healthValue;
        if(healthValue <= 40)
        {
            bloodBarUI.GetComponent<Image>().color = new Color(255, 0, 0, 255);
        }
        else
        {
            bloodBarUI.GetComponent<Image>().color = new Color(0, 255, 0, 255);
        }
    }
}
