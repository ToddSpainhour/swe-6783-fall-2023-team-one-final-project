using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject interactiveItem;

    public bool[] isSlotEmpty;
    public static List<GameObject> inventory;


    void Awake()
    {
        interactiveItem = GameObject.Find("InteractiveObject").GetComponent<GameObject>();
    }

    public void OnMouseDown()
    {
        Debug.Log("interactive item name: " + interactiveItem.name);
    }

}
