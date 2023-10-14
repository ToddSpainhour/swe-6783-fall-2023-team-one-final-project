using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationRoomInventoryItem : MonoBehaviour
{
    public string itemName = "";
    public string itemDescription = "";

    public GameObject DynamicItemName;
    public GameObject DynamicItemDescription;
    public FollowMouse followMousescript;


    void Start()
    {
        this.enabled = false;
    }


    public void OnMouseEnter()
    {
        DynamicItemName.GetComponent<UnityEngine.UI.Text>().text = itemName;
    }


    public void OnMouseExit()
    {
        DynamicItemName.GetComponent<UnityEngine.UI.Text>().text = "";
        DynamicItemDescription.GetComponent<UnityEngine.UI.Text>().text = "";
    }


    public void OnMouseDown()
    {
        if (itemName == "GlovesInInventory")
        {
            Debug.Log("onMouseDown for GlovesInInventory");
            ActiveInventoryItem.SetCurrentActiveInventoryItem("Gloves");
            AttachGlovesToCursor();
        }
    }


    public void OnMouseUp()
    {
        DynamicItemDescription.GetComponent<UnityEngine.UI.Text>().text = itemDescription;
        AttachGlovesToCursor();
    }


    public void AttachGlovesToCursor()
    {
        followMousescript.HaveIconFollowCursor();
    }
}

