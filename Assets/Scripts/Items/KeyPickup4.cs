using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup4 : MonoBehaviour
{
    public GameObject theKey;
    public AudioSource keySound;
    public GameObject theLeftDoor;
    public GameObject theRightDoor;
    public AudioSource doorOpenSound;
    public GameObject theProtect4;

    void OnTriggerEnter(Collider other)
    {
        Destroy(theKey);
        keySound.Play();
        Destroy(theProtect4);
        theLeftDoor.GetComponent<Animator>().Play("LeftDoorOpen4");
        theRightDoor.GetComponent<Animator>().Play("RightDoorOpen4");
        doorOpenSound.Play();
    }
}
