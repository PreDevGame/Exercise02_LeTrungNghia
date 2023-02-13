using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour
{
    public static int theAmmoValue;
    public GameObject ammoDisplay;

    void Update()
    {
        ammoDisplay.GetComponent<Text>().text = "" + theAmmoValue;
    }
}
