using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTimer : MonoBehaviour
{

    public Timer timerScript;

    void Start()
    {
        timerScript.ResetTotalTimeToFinish();
    }
}
