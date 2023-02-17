using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SoldierAI : MonoBehaviour
{
    public string hitTag;
    public bool lookingAtPlayer = false;
    public GameObject theSoldier;
    public AudioSource fireSound;
    public bool isFiring = false;
    public float fireRate = 0.025f;
    public GameObject bloodPlayerLoss;
    public GameObject bloodPlayerBar;


    void Start()
    {
        bloodPlayerLoss.SetActive(false);
    }
    void Update()
    {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
           hitTag = Hit.transform.tag;
        }
        if ((hitTag == "Player") && (isFiring == false))
        {
            if (GlobalBlood.healthValue > 0)
            {
                StartCoroutine(EnemyAuto());
            }
            if (GlobalBlood.healthValue <= 0)
            {
                theSoldier.GetComponent<Animator>().Play("Standing");
            }
        }
        if (hitTag != "Player")
        {
            theSoldier.GetComponent<Animator>().Play("Standing");
            lookingAtPlayer = false;
        }

    }
    IEnumerator EnemyAuto()
    {
        isFiring = true;
        lookingAtPlayer = true;
        fireSound.Play();
        bloodPlayerLoss.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        bloodPlayerLoss.SetActive(false);
        bloodPlayerBar.GetComponent<RectTransform>().offsetMin += new Vector2(70, 0);
        theSoldier.GetComponent<Animator>().Play("Firing");
        yield return new WaitForSeconds(fireRate);
        isFiring = false;
    }
}
