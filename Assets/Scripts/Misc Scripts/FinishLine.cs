using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject.Find("Player").SendMessage("FinishSignal");
        Debug.Log("Works");
    }
}
