using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutor1 : MonoBehaviour
{
    public GameObject theRobot;
    public AudioSource robotVoice;
    public GameObject pannelTutor1;
    public GameObject theStartTrigger;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(robotsTutor1());
        
    }

    IEnumerator robotsTutor1()
    {
        theRobot.SetActive(true);
        robotVoice.Play();
        pannelTutor1.SetActive(true);
        yield return new WaitForSeconds(8);
        Destroy(theStartTrigger);
        pannelTutor1.SetActive(false);
        theRobot.SetActive(false);
        robotVoice.Pause();


    }
}
