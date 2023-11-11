using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvanceThroughMuseum : MonoBehaviour
{
    public GameObject paintingOnHiddenDoor;
    public GameObject hiddenDoorOpen;
    public GameObject exit;

    public void OpenHiddenDoor()
    {
        paintingOnHiddenDoor.SetActive(false);
        hiddenDoorOpen.SetActive(true);
        exit.SetActive(true);
    }

}
