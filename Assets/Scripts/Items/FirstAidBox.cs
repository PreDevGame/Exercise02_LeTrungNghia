using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAidBox : MonoBehaviour
{
    public GameObject theBox;
    public AudioSource increaseBloodSound;
    
    public GameObject bloodBar;
    public GameObject theLeftDoor;
    public GameObject theRightDoor;
    public AudioSource theDoorSound;

    void OnTriggerEnter(Collider other)
    {
        Destroy(theBox);
        GlobalBlood.healthValue += 50;
        increaseBloodSound.Play();
        bloodBar.GetComponent<RectTransform>().offsetMin -= new Vector2(150, 0);
        theLeftDoor.GetComponent<Animator>().Play("LeftDoorOpen");
        theRightDoor.GetComponent<Animator>().Play("RightDoorOpen");
        theDoorSound.Play();
    }


        
}
