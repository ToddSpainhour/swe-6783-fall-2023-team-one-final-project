using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AdvanceThroughGame : MonoBehaviour
{
    // this class is attached to the door hotspot which for this room (Lobby) is the "win condition";
    // it would make sense for each room to have it's own standalone file like
    public void OnMouseDown()
    {
        Debug.Log("inside advanceThroughGame class");
        string currentSelectedInventoryItem = ActiveInventoryItem.GetCurrentActiveInventoryItem();

        if(currentSelectedInventoryItem == "")
        {
            return;
        }
        else
        {
            if (currentSelectedInventoryItem == "Keycard")
            {
                Debug.Log("yahoo. You win the room");
                // advance to next scene
            }
        }


    }
}
