using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public GameObject theScoreText;
    public static int theCurrentScore;

    void Start()
    {
        theCurrentScore = 0;
    }
    void LateUpdate()
    {
        if(GunFire.theSoliderKilled == 4)
        {
            theCurrentScore = 0;
        }
        else
        {
            theCurrentScore = GiftPickup.theScoreValue;
        }
        
        Debug.LogWarning(theCurrentScore);
        theScoreText.GetComponent<Text>().text = "" + theCurrentScore;
    }
}
