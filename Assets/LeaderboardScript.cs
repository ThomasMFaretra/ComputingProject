using UnityEngine.UI;
using LootLocker.Requests;
using UnityEngine;

public class LeaderboardScript : MonoBehaviour
{
    public InputField PlayerScore;
    public int ID;
    public string PlayerName;
    public Text[] Entry;
    int ScoreLength = 5;

    
    void Start()
    {
        LootLockerSDKManager.StartSession("Player", (response) =>
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
        RetrieveScores();
    }

    public void RetrieveScores()
    {
        LootLockerSDKManager.GetScoreList(ID, ScoreLength, (response) =>
        {
            if (response.success)
            {
                LootLockerLeaderboardMember[] scores = response.items;
                for (int i = 0; i < scores.Length; i++)
                {
                    string minutes = ((int)(((float)scores[i].score / 1000) / 60)).ToString();
                    string seconds = (((float)scores[i].score / 1000) % 60).ToString("f3");
                    Entry[i].text = minutes + ":" + seconds;
                }
                if (scores.Length < ScoreLength)
                {
                    for (int i = scores.Length; i < ScoreLength; i++)
                    {
                        Entry[i].text = ("empty");
                    }
                }
            }
            else
            {
                Debug.Log("LootLocker failed Response");
            }
        });
    }

    public void SubmitScore()
    {
        LootLockerSDKManager.SubmitScore(Random.Range(100000, 999999).ToString(), int.Parse(PlayerScore.text), ID, (response) =>
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

    public void SubmitAndRetrieve()
    {
        SubmitScore();
        RetrieveScores();
    }


}
