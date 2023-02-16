using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunFire : MonoBehaviour
{
    public GameObject theGun;
    public GameObject muzzelFlash;
    public AudioSource gunFire;
    public AudioSource NoAnyAmmo;
    public bool isFiring = false;
    public string soldierTag;
    public static bool soldierBloodLoss = false;
    public GameObject bloodSoldierBar;
    public GameObject theSoldier;
    public GameObject firstAidBox01;

    void Update()
    {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            soldierTag = Hit.transform.tag;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            if (GlobalAmmo.theAmmoValue > 0)
            {
                if (isFiring == false)
                {
                    StartCoroutine(firingHandGun());
                    if(soldierTag == "Soldier")
                    {
                        soldierBloodLoss = true;
                        Debug.Log(" Da Ban Trung ");
                        bloodSoldierBar.GetComponent<Image>().fillAmount -= 0.5f;
                        if(bloodSoldierBar.GetComponent<Image>().fillAmount == 0)
                        {
                            Destroy(theSoldier);
                            firstAidBox01.SetActive(true);
                        }

                    }
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
