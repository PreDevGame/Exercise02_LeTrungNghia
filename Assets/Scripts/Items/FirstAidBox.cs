using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAidBox : MonoBehaviour
{
    public GameObject theBox;
    public AudioSource increaseBloodSound;
    public GameObject bloodBar;
    public int currentBlood;

    void OnTriggerEnter(Collider other)
    {

        Destroy(theBox);
        GlobalBlood.healthValue += 50;
        currentBlood = GlobalBlood.healthValue;
        increaseBloodSound.Play();
        if (currentBlood >= 100)
        {
            bloodBar.GetComponent<RectTransform>().offsetMin = new Vector2(100, -440);
            bloodBar.GetComponent<RectTransform>().offsetMax = new Vector2(337, -520);
        }
        else
        {
            bloodBar.GetComponent<RectTransform>().offsetMin -= new Vector2(150, 0);
        }
    }
     
}
