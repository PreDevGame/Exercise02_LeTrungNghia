using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthGlobalSoldier : MonoBehaviour
{
    public static int healthSoldier;
    public int internalHealth;

    void Start()
    {
        healthSoldier = 100;
    }

    void Update()
    {
        internalHealth = healthSoldier;
    }
}
