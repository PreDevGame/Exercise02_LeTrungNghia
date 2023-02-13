using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    public GameObject theGun;
    public GameObject muzzelFlash;
    public AudioSource gunFire;
    public AudioSource NoAnyAmmo;
    public bool isFiring = false;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (GlobalAmmo.theAmmoValue > 0)
            {
                if (isFiring == false)
                {
                    StartCoroutine(firingHandGun());
                }

            }
            else
            {
                if(isFiring == false)
                {
                    StartCoroutine(noAmmo());
                }
                
            }
        }
        
    }

    IEnumerator firingHandGun()
    {
        isFiring = true;
        theGun.GetComponent<Animator>().Play("Shooting");
        muzzelFlash.SetActive(true);
        gunFire.Play();
        GlobalAmmo.theAmmoValue -= 1;
        yield return new WaitForSeconds(0.05f);
        muzzelFlash.SetActive(false);
        yield return new WaitForSeconds(0.15f);
        theGun.GetComponent<Animator>().Play("New State");
        isFiring = false;
    }

    IEnumerator noAmmo()
    {
        isFiring = true;
        theGun.GetComponent<Animator>().Play("Shooting");
        muzzelFlash.SetActive(false);
        NoAnyAmmo.Play();
        yield return new WaitForSeconds(0.05f);
        muzzelFlash.SetActive(false);
        yield return new WaitForSeconds(0.15f);
        theGun.GetComponent<Animator>().Play("New State");
        isFiring = false;
    }
}
