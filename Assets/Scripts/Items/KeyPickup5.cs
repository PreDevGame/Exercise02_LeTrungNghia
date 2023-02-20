using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup5 : MonoBehaviour
{
    public GameObject theKey;
    public AudioSource keySound;
    public GameObject theLeftDoor;
    public GameObject theRightDoor;
    public AudioSource doorOpenSound;
    public GameObject theProtect5;

    void OnTriggerEnter(Collider other)
    {
        Destroy(theKey);
        keySound.Play();
        Destroy(theProtect5);
        theLeftDoor.GetComponent<Animator>().Play("LeftDoorOpen5");
        theRightDoor.GetComponent<Animator>().Play("RightDoorOpen5");
        doorOpenSound.Play();
    }
}
