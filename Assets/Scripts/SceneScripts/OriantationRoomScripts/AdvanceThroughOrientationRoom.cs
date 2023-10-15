using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdvanceThroughOrientationRoom : MonoBehaviour
{
    OrientationRoomManager orientationRoomManagerScript;

    public void Start()
    {
        orientationRoomManagerScript = FindObjectOfType<OrientationRoomManager>();
    }


    public void OnMouseDown()
    {
        string currentSelectedInventoryItem = ActiveInventoryItem.GetCurrentActiveInventoryItem();

        if (currentSelectedInventoryItem == "")
        {
            return;
        }
        else
        {
            if (currentSelectedInventoryItem == "Gloves")
            {
                orientationRoomManagerScript.PowerUpOrientationRoom();
            }
        }
    }
}
