using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup2 : MonoBehaviour
{
    public GameObject theKey;
    public AudioSource keySound;
    public GameObject theLeftDoor;
    public GameObject theRightDoor;
    public AudioSource doorOpenSound;
    public GameObject theProtect2;

    void OnTriggerEnter(Collider other)
    {
        Destroy(theKey);
        keySound.Play();
        Destroy(theProtect2);
        theLeftDoor.GetComponent<Animator>().Play("LeftDoorOpen02");
        theRightDoor.GetComponent<Animator>().Play("RightDoorOpen02");
        doorOpenSound.Play();
    }
}
