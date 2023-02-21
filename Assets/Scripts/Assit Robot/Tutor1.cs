using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutor1 : MonoBehaviour
{
    public GameObject theRobot;
    public AudioSource robotVoice;
    public GameObject pannelTutor;
    public GameObject text0;
    public GameObject text1;
    public GameObject text2;
    public GameObject theStartTrigger;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(robotsTutor1());
        
    }

    IEnumerator robotsTutor1()
    {
        theRobot.SetActive(true);
        robotVoice.Play();
        pannelTutor.SetActive(true);
        text0.SetActive(true);
        yield return new WaitForSeconds(2);
        text0.SetActive(false);
        text1.SetActive(true);
        yield return new WaitForSeconds(4);
        text1.SetActive(false);
        text2.SetActive(true);
        yield return new WaitForSeconds(3);
        text2.SetActive(false);
        pannelTutor.SetActive(false);
        Destroy(theStartTrigger);
        theRobot.SetActive(false);
        robotVoice.Pause();
    }
}
