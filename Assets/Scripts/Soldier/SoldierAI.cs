using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAI : MonoBehaviour
{
    public string hitTag;
    public bool lookingAtPlayer = false;
    public GameObject theSoldier;
    public AudioSource fireSound;
    public bool isFiring = false;
    public float fireRate = 1.5f;

    void Update()
    {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit, 15.0f))
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
        lookingAtPlayer = true;
        isFiring = true;
        theSoldier.GetComponent<Animator>().Play("Firing");
        yield return new WaitForSeconds(fireRate);
        fireSound.Play();
        yield return new WaitForSeconds(0.5f);
        isFiring = false;
    }
}
