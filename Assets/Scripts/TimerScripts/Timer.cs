using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public static float totalTimeToFinish = 0f;
    public bool isStillPlaying = true;

    void Update()
    {
        if(isStillPlaying)
        {
            totalTimeToFinish += Time.deltaTime;
        }
    }


    public string GetTotalTimeToFinish()
    {
        TimeSpan time = TimeSpan.FromSeconds(totalTimeToFinish);
        string formattedTime = time.ToString("mm':'ss");
        return formattedTime;
    }

    public void ResetTotalTimeToFinish()
    {
        totalTimeToFinish = 0f;
    }
}
