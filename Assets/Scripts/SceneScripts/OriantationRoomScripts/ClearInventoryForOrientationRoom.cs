using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearInventoryForOrientationRoom : MonoBehaviour
{
    public GameObject glovesInInventory;

    public void RemoveGlovesFromInventory()
    {
        glovesInInventory.SetActive(false);
    }
}
