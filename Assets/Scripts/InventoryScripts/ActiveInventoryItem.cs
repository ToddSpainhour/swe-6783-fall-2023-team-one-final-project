using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class ActiveInventoryItem
{

    public static string currentActiveInventoryItem = "";


    public static void SetCurrentActiveInventoryItem(string passedInValue)
    {
        //Debug.Log("Setting CurrentActiveInventoryItem : " + passedInValue);
        currentActiveInventoryItem = passedInValue;

        //Debug.Log("lets see what is gets... " + GetCurrentActiveInventoryItem());
    }


    public static string GetCurrentActiveInventoryItem()
    {
        Debug.Log("getting the currentActiveInvenotryItem");
        string valueToReturn = currentActiveInventoryItem;
        return valueToReturn;
    }
}
