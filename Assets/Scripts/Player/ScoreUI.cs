using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public GameObject theScoreText;
    public int theCurrentScore;

    void Update()
    {
        theCurrentScore = GiftPickup.theScoreValue;
        Debug.LogWarning(theCurrentScore);
        theScoreText.GetComponent<Text>().text = "" + theCurrentScore;
    }
}
