using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AdvanceThroughGame : MonoBehaviour
{
    // needs to know about door hotspot
    //public GameObject doorHotspot;
    // needs to know about activeInventoryItem
    //public ActiveInventoryItem activeInventoryItem;

    //GameObject.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        Debug.Log("inside advanceThroughGame class");
        string value = ActiveInventoryItem.GetCurrentActiveInventoryItem();
        //string value = activeInventoryItem.GetCurrentActiveInventoryItem();
        //string value = activeInventoryItem.currentActiveInventoryItem;

        Debug.Log("value: " + value);

        if(value == "")
        {
            Debug.Log("the value for active inventoryItem was a empty string");
            //return;
        }
        else
        {
            //Debug.Log("the value for active inventoryItem was NOT an empty string and we'rein the else statement");
            if (value == "Keycard")
            {
                Debug.Log("yahoo. You win the room");
            }
        }


    }
}
