using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public AudioSource playerDeathSound;
    public AudioSource GameOverSound;
    public GameObject gameOverUI;

    void Update()
    {
        if(GlobalBlood.healthValue == 0)
        {
            StartCoroutine(gameOver());
        }
    }

    IEnumerator gameOver()
    {
        yield return new WaitForSeconds(1);
        playerDeathSound.Play();
        //yield return new WaitForSeconds(0.25f);
        //GameOverSound.Play();
        //yield return new WaitForSeconds(0.25f);
        gameOverUI.SetActive(true);
        gameOverUI.GetComponent<Animator>().Play("GameOver");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);

    }
}
