using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveOrientationRoom : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("MuseumRoom");
    }
}
