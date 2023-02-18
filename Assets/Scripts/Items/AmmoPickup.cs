using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public GameObject theAmmoFake;
    public AudioSource thePickupSound;
    public AudioSource theGunLoad;
    public static bool pickupSucceced = false;

    

    void OnTriggerEnter(Collider other)
    {

        if (PickupGun.gotGun == true)
        {
            gotGun();
        }
        if(PickupGun.gotGun == false)
        {
            noGun();
        }
        
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
