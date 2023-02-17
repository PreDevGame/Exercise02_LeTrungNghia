using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePickup : MonoBehaviour
{
    public int theScoreValue;
    public GameObject theScoreUI;
    public GameObject scoreTrigger;
    public GameObject giftBox;
    public AudioSource giftSound;

    void Start()
    {
        theScoreValue = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(giftBox);
        giftSound.Play();
        theScoreValue += 100;
        theScoreUI.GetComponent<Text>().text = "" + theScoreValue;
    }

}
