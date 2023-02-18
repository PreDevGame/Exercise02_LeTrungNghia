using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPass : MonoBehaviour
{
    [SerializeField]
    private Text ansEnter;
    public static bool activePass = true;

    
    public void Number(int number)
    {
        ansEnter.text += number.ToString();
    }
}
