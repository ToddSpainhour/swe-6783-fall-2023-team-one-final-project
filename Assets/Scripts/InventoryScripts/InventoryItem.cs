using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : MonoBehaviour
{

    public string itemName = "";
    public string itemDescription = "";
    //public string activeInventoryItem = "";

    public GameObject DynamicItemName;
    public GameObject DynamicItemDescription;
    public FollowMouse followMousescript;
    // try Finding it instead of this method
    //public ActiveInventoryItem activeInventoryItem;

    //ReferencedScript refScript = GetComponent<ReferencedScript>();
    


    void Start()
    {
        this.enabled = false;
        //ActiveInventoryItem activeInventoryItemScript = GetComponent<ActiveInventoryItem>();
    }


    void Update()
    {
        // make the icon stick to the cursor here?
    }


    public void OnMouseEnter()
    {
        DynamicItemName.GetComponent<UnityEngine.UI.Text>().text = itemName;
        //Debug.Log("InventoryItem onMouseEnter");
    }


    public void OnMouseExit()
    {
        DynamicItemName.GetComponent<UnityEngine.UI.Text>().text = "";
        DynamicItemDescription.GetComponent<UnityEngine.UI.Text>().text = "";
        //Debug.Log("InventoryItem onMouseExit");
    }

    public void OnMouseDown()
    {
        if(itemName == "Keycard")
        {
            AttachKeyCardToCursor();
            ActiveInventoryItem.SetCurrentActiveInventoryItem("Keycard");
        }

        

        // how to know what item is attached to cursor?
        // if you click on the door hotspot with the keycard attached to your cursor, yay you win
    }


    public void OnMouseUp()
    {
        DynamicItemDescription.GetComponent<UnityEngine.UI.Text>().text = itemDescription;
        //Debug.Log("you clicked on: " + itemName + " in the inventory!");
        
    }

    public void AttachKeyCardToCursor()
    {
        //Debug.Log("attach " + itemName + " to cursor");
        followMousescript.enabled = true;
        followMousescript.HaveIconFollowCursor();

        // this "works" but only moves when you click. doesn't follow cursor
        /*
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
        transform.position = mousePosition;
        */
    }



}
