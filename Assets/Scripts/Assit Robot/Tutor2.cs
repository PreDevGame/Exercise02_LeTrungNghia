using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutor2 : MonoBehaviour
{
    public GameObject theRobot;
    public GameObject tutorText;
    public AudioSource robotVoice;
    public GameObject theTrigger;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(robotTutor());
    }

    IEnumerator robotTutor()
    {
        theRobot.SetActive(true);
        robotVoice.Play();
        tutorText.SetActive(true);
        yield return new WaitForSeconds(2);
        Destroy(theTrigger);
        tutorText.SetActive(false);
        robotVoice.Pause();
        theRobot.SetActive(false);
    }
}
