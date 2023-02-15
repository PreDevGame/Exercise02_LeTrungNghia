using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierMoveAround : MonoBehaviour
{
    [SerializeField]
    private float movespeed = 1f;
    public GameObject soldierRun;

    void Update()
    {
        soldierRun.GetComponent<Animator>().Play("Run");
        transform.position += transform.forward * movespeed * Time.deltaTime;
        transform.Rotate(0f, -10f, 0f);
    }
}
