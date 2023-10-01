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


    public void OnMouseEnter()
    {
        DynamicItemName.GetComponent<UnityEngine.UI.Text>().text = itemName;
        Debug.Log("InventoryItem onMouseEnter");
    }


    public void OnMouseExit()
    {
        DynamicItemName.GetComponent<UnityEngine.UI.Text>().text = "";
        // this also clears out the desciption; need to find a way to fade this out instead
        DynamicItemDescription.GetComponent<UnityEngine.UI.Text>().text = "";
        Debug.Log("InventoryItem onMouseExit");
    }

    public void OnMouseDown()
    {
        AttachKeyCardToCursor();
    }


    public void OnMouseUp()
    {
        DynamicItemDescription.GetComponent<UnityEngine.UI.Text>().text = itemDescription;
        Debug.Log("you clicked on: " + itemName + " in the inventory!");
        
    }

    public void AttachKeyCardToCursor()
    {
        Debug.Log("attach " + itemName + " to cursor");
        followMousescript.enabled = true;
        followMousescript.HaveIconFollowCursor();

        // this "works" but only moves when you click. doesn't follow cursor
        /*
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
        transform.position = mousePosition;
        */
    }


    // Start is called before the first frame update
    void Start()
    {
        this.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // make the icon stick to the cursor here?
    }
}
