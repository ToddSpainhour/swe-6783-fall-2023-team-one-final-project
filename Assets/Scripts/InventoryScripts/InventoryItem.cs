using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : MonoBehaviour
{

    public string itemName = "";
    public string itemDescription = "";

    public GameObject DynamicItemName;
    public GameObject DynamicItemDescription;


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


    public void OnMouseUp()
    {
        DynamicItemDescription.GetComponent<UnityEngine.UI.Text>().text = itemDescription;
        // hmm how to fade the text out after a certain period??
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
