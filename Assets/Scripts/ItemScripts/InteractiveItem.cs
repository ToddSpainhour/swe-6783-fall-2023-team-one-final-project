using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // these properties show up in Unity where the values can be entered
    public string itemName = "";
    public string itemDescription = "";
    public bool isInventoryEligible;


    // this creates a slot in Unity where you can connect it to a GameObject by dragging and dropping
    // it tells this file what GameObject you're talking about
    public GameObject DynamicItemName;
    public GameObject DynamicItemDescription;


    public void OnMouseEnter()
    {
        DynamicItemName.GetComponent<UnityEngine.UI.Text>().text = itemName;
    }


    public void OnMouseExit()
    {
        DynamicItemName.GetComponent<UnityEngine.UI.Text>().text = "";
        DynamicItemDescription.GetComponent<UnityEngine.UI.Text>().text = "";
    }


    public void OnMouseUp()
    {
        DynamicItemDescription.GetComponent<UnityEngine.UI.Text>().text = itemDescription;
        // hmm how to fade the text out after a certain period??
    }
}
