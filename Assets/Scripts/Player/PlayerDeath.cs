using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public AudioSource GameOverSound;
    public GameObject gameOverUI;

    void Update()
    {
        if(GlobalBlood.healthValue == 0)
        {
            StartCoroutine(gameOver());
            GunFire.theSoliderKilled = 4;
            ScoreUI.theCurrentScore = 0;
            GlobalAmmo.theAmmoValue = 0;
        }
    }

    IEnumerator gameOver()
    {
        GameOverSound.Play();
        gameOverUI.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);

    }
}
