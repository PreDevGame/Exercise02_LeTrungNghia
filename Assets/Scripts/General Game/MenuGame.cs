using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuGame : MonoBehaviour
{
    public GameObject fakeOut;
    public AudioSource clickSound;

    [Header("Mouse Cursor Settings")]
    public bool cursorLocked = false;
    public bool cursorInputForLook = true;


    public void buttonNewGame()
    {
        StartCoroutine(NewGame());
    }

    IEnumerator NewGame()
    {
        clickSound.Play();
        StarterAssets.StarterAssetsInputs.cursorLocked = true;
        StarterAssets.StarterAssetsInputs.cursorInputForLook = true;
        yield return new WaitForSeconds(2);
        fakeOut.SetActive(true);
        SceneManager.LoadScene(0);
    }

}
