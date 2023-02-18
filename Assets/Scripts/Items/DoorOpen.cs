using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject theLeftDoor;
    public GameObject theRightDoor;
    public AudioSource doorOpenSound;
    public GameObject proctectDoor1;

    void OnTriggerEnter(Collider other)
    {
        Destroy(proctectDoor1);
        doorOpenSound.Play();
        theLeftDoor.GetComponent<Animator>().Play("LeftDoorOpen");
        theRightDoor.GetComponent<Animator>().Play("RightDoorOpen");
    }

    void OnTriggerExit(Collider other)
    {
        doorOpenSound.Play();
        theLeftDoor.GetComponent<Animator>().Play("LeftDoorClose");
        theRightDoor.GetComponent<Animator>().Play("RightDoorClose");
    }
}
