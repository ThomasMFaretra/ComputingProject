using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLine : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject.Find("Player").SendMessage("StartSignal");
        Debug.Log("Works");
    }
}
