using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItems : MonoBehaviour
{
    public GameObject theRealGun;
    public GameObject theFakeGun;
    public AudioSource thePickupSound;
    public static bool gotGun = false;

    void OnTriggerEnter(Collider other)
    {
        gotGun = true;
        thePickupSound.Play();
        Destroy(theFakeGun);
        theRealGun.SetActive(true);
    }

}
