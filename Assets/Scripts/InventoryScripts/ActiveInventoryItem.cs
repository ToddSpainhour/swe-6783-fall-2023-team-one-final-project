using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class ActiveInventoryItem
{

    public static string currentActiveInventoryItem = "";


    public static void SetCurrentActiveInventoryItem(string passedInValue)
    {
        currentActiveInventoryItem = passedInValue;
    }


    public static string GetCurrentActiveInventoryItem()
    {
        string valueToReturn = currentActiveInventoryItem;
        return valueToReturn;
    }
}
