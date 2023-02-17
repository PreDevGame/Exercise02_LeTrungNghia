using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftPickup : MonoBehaviour
{
    public GameObject giftBox;
    public AudioSource giftSound;
    public static int theScoreValue;

    void OnTriggerEnter(Collider other)
    {
        Destroy(giftBox);
        giftSound.Play();
        theScoreValue += 100;
    }

}
