using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ActiveInventoryItem
{

    public static string currentActiveInventoryItem;


    public static void SetCurrentActiveInventoryItem(string passedInValue)
    {
        //Debug.Log("inside SetCurrentActiveInventoryItem(): " + passedInValue);
        currentActiveInventoryItem = passedInValue;
        Debug.Log("GetCurrentActiveInventoryItem() inside the set method" + GetCurrentActiveInventoryItem());
    }


    public static string GetCurrentActiveInventoryItem()
    {
        string valueToReturn = currentActiveInventoryItem;
        //Debug.Log("inside GetCurrentActiveInventoryItem()");
        Debug.Log("currentActiveInventoryItem should be returning: " + valueToReturn);
        return valueToReturn;
    }
}
