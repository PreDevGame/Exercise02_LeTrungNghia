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
    public float fireRate = 0.5f;

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
            isFiring = false;
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
        theSoldier.GetComponent<Animator>().Play("Firing");
        fireSound.Play();
        lookingAtPlayer = true;
        yield return new WaitForSeconds(fireRate);
    }
}
