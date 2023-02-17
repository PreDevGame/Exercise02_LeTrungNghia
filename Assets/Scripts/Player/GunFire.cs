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
    public GameObject bloodSoldierBar1;
    public GameObject theSoldier1;
    public GameObject bloodSoldierBar2;
    public GameObject theSoldier2;
    public GameObject firstAidBox1;
    public GameObject giftBox1;
    public GameObject giftBox2;
    public static int theSoliderKilled = 4;

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
                    if(soldierTag == "Soldier1")
                    {
                        soldierBloodLoss = true;
                        Debug.Log(" Da Ban Trung ");
                        bloodSoldierBar1.GetComponent<Image>().fillAmount -= 0.5f;
                        if(bloodSoldierBar1.GetComponent<Image>().fillAmount == 0)
                        {
                            Destroy(theSoldier1);
                            theSoliderKilled -= 1;
                            firstAidBox1.SetActive(true);
                            giftBox1.SetActive(true);

                        }
                    }
                    if (soldierTag == "Soldier2")
                    {
                        soldierBloodLoss = true;
                        Debug.Log(" Da Ban Trung ");
                        bloodSoldierBar2.GetComponent<Image>().fillAmount -= 0.5f;
                        if (bloodSoldierBar2.GetComponent<Image>().fillAmount == 0)
                        {
                            Destroy(theSoldier2);
                            theSoliderKilled -= 1;
                            giftBox2.SetActive(true);

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
