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
    public float fireRate = 1.5f;
    public GameObject beingAttacked;
    public GameObject bloodBar;

    void Start()
    {
        beingAttacked.SetActive(false);
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
            StartCoroutine(EnemyAuto());

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
        theSoldier.GetComponent<Animator>().Play("Firing");
        yield return new WaitForSeconds(fireRate);
        fireSound.Play();
        yield return new WaitForSeconds(0.5f);
        GlobalBlood.healthValue -= 10;
        beingAttacked.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        beingAttacked.SetActive(false);
        bloodBar.GetComponent<RectTransform>().offsetMin -= new Vector2(-10, 0);
        isFiring = false;

    }
}
