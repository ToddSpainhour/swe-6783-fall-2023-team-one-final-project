using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //public bool[] isSlotEmpty;
    public List<string> inventoryList;

    public void addItemToInventory(string itemName)
    {
        Debug.Log("you just ran the addItemToInventory method");

        inventoryList.Add(itemName);

        for (int i = 0; i < inventoryList.Count; i++)
        {
            Debug.Log($"inventory slot {i}: {inventoryList[i]}");
        }
    }
}
