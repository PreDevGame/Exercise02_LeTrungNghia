using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatPlayer : MonoBehaviour
{
    public Transform theMainPlayer;

    void Update()
    {
        transform.LookAt(theMainPlayer);
    }
}
