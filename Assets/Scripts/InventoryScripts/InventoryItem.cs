using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : MonoBehaviour
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
        if(itemName == "Keycard")
        {
            ActiveInventoryItem.SetCurrentActiveInventoryItem("Keycard");
            AttachKeyCardToCursor();
        }
    }


    public void OnMouseUp()
    {
        DynamicItemDescription.GetComponent<UnityEngine.UI.Text>().text = itemDescription;
    }


    public void AttachKeyCardToCursor()
    {
        followMousescript.HaveIconFollowCursor();
    }
}
