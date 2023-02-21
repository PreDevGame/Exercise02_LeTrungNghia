using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public GameObject theTreasure;
    public GameObject theBook;
    public AudioSource treasureSound;
    public AudioSource victorySound;
    public GameObject theRobot;
    public GameObject vicoryPannel;
    public GameObject totalScorePannel;

    void OnTriggerEnter(Collider other)
    {
        theTreasure.SetActive(true);
        if(GoldKey.hasKey == 1)
        {
            StartCoroutine(VicrotyAnimate());
        }
    }

    IEnumerator VicrotyAnimate()
    {
        yield return new WaitForSeconds(1);
        treasureSound.Play();
        theTreasure.GetComponent<Animator>().Play("ArmatureAction");
        yield return new WaitForSeconds(8);
        treasureSound.Pause();
        theBook.SetActive(true);
        theBook.GetComponent<Animator>().Play("Go out");
        yield return new WaitForSeconds(0.2f);
        theBook.GetComponent<Animator>().Play("Take 01");
        victorySound.Play();
        theRobot.SetActive(true);
        vicoryPannel.SetActive(true);
        yield return new WaitForSeconds(6);
        vicoryPannel.SetActive(false);
        totalScorePannel.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);

    }
}
