using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItems : MonoBehaviour
{
    public GameObject theRealGun;
    public GameObject theFakeGun;
    public AudioSource thePickupSound;

    void OnTriggerEnter(Collider other)
    {
        Destroy(theFakeGun);
        thePickupSound.Play();
        theRealGun.SetActive(true);
    }
}
