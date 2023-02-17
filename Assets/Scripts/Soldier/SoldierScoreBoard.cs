using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SoldierScoreBoard : MonoBehaviour
{
    [SerializeField]
    private int totalSolider;
    public GameObject soldierValue;

    void Start()
    {
        totalSolider = 4;
    }
    void Update()
    {
        totalSolider = GunFire.theSoliderKilled;
        soldierValue.GetComponent<Text>().text = "" + totalSolider;
    }
}
