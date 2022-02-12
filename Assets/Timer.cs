using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text text;
    private float currentTime;
    private bool started = false;
    private bool finished = false;
    private float startTime;

    void Update()
    {
        if (started == true)
        {
            currentTime = currentTime + Time.deltaTime;
            string minutes = ((int)currentTime / 60).ToString();
            string seconds = (currentTime % 60).ToString("f3");
            text.text = minutes + ":" + seconds;
        }
    }
    public void StartSignal()
    {
        if (finished == false)
        {
            currentTime = 0f;
            started = true;
        }
    }

    public void FinishSignal()
    {
        started = false;
        finished = true;
        text.color = Color.green;
    }
}
