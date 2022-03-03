using System.Collections;
using System.Collections.Generic;
using LootLocker.Requests;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text text;
    public int ID;
    private float currentTime;
    private int scoretime;
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
            scoretime = (int)(currentTime * 1000);
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
        if (finished == false)
        {
            started = false;
            finished = true;
            text.color = Color.green;
            SubmitScore();
        }    
    }

    private void SubmitScore()
    {
        LootLockerSDKManager.SubmitScore(Random.Range(100000, 999999).ToString(), scoretime, ID, (response) =>
        {
            if (response.success)
            {
                Debug.Log("LootLocker Successful Response");
            }
            else
            {
                Debug.Log("LootLocker failed Response");
            }
        });
    }
}
