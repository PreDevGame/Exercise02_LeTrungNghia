using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public GameObject theAmmoFake;
    public AudioSource thePickupSound;
    public AudioSource theGunLoad;
    public static bool pickupSucceced = false;
    public AudioSource doorOpenSound;
    public GameObject theLeftDoor;
    public GameObject theRightDoor;
    

    void OnTriggerEnter(Collider other)
    {

        if (PickupItems.gotGun == true)
        {
            gotGun();
        }
        if(PickupItems.gotGun == false)
        {
            noGun();
        }
        
        doorOpenSound.Play();
        theLeftDoor.GetComponent<Animator>().Play("LeftDoorOpen02");
        theRightDoor.GetComponent<Animator>().Play("RightDoorOpen02");
    }

    void gotGun()
    {
        pickupSucceced = true;
        theGunLoad.Play();
        Destroy(theAmmoFake);
        GlobalAmmo.theAmmoValue += 10;
    }

    void noGun()
    {
        pickupSucceced = true;
        thePickupSound.Play();
        Destroy(theAmmoFake);
        GlobalAmmo.theAmmoValue += 10;
    }


}
