using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdvanceThroughOrientationRoom : MonoBehaviour
{

    //public OrientationRoomManager orientationRoomManagerScript;

    public void Start()
    {
        //Debug.Log("AdvanceThroughOrientationRoom script just started");
    }

    public void OnMouseDown()
    {
        Debug.Log("on mouse up AdvanceThroughOrientationRoom");

        string currentSelectedInventoryItem = ActiveInventoryItem.GetCurrentActiveInventoryItem();
        Debug.Log("currentSelectedInventoryItem: " + currentSelectedInventoryItem);

        if (currentSelectedInventoryItem == "")
        {
            //Debug.Log("wait... currentSelectedInventoryItem was an empy string");
            return;
        }
        else
        {
            Debug.Log("currentSelectedInventoryItem was NOT an empy string");

            if (currentSelectedInventoryItem == "Gloves")
            {
                Debug.Log("You fixed the power!");
                // advance to next scene
                //SceneManager.LoadScene("ToBeContinued");
                //orientationRoomManagerScript.PowerUpOrientationRoom();
            }
        }


    }
}
