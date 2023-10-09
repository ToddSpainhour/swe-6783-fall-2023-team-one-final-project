using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTimer : MonoBehaviour
{
    public Timer timerScript;
    public GameObject totalTimePlayed;

    void Start()
    {
        StopTheTimer();
    }


    public void StopTheTimer()
    {
        timerScript.isStillPlaying = false;
        string value = timerScript.GetTotalTimeToFinish();
        totalTimePlayed.GetComponent<UnityEngine.UI.Text>().text = value;
    }
}
