using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldKey : MonoBehaviour
{
    public GameObject theGoldKey;
    public AudioSource goldKeySound;
    public static int hasKey = 0;

    void OnTriggerEnter(Collider other)
    {
        Destroy(theGoldKey);
        goldKeySound.Play();
        hasKey = 1;
    }
}
