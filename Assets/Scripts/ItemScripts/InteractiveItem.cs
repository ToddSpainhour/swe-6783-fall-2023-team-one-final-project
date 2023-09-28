using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // these properties show up in Unity where the values can be entered
    public string itemName = "";
    public string itemDescription = "";
    public bool isInventoryEligible;


    // this creates a slot in Unity to tell this file what GameObject you're talking about
    public GameObject DynamicItemName;
    public GameObject DynamicItemDescription;


    // displays dynamicItemName
    public void OnMouseEnter()
    {
        DynamicItemName.GetComponent<UnityEngine.UI.Text>().text = itemName;
        //Debug.Log("onMouseEnter in InteractiveItem");
    }


    // clears dynamicItemName
    public void OnMouseExit()
    {
        DynamicItemName.GetComponent<UnityEngine.UI.Text>().text = "";
        // this also clears out the desciption; need to find a way to fade this out instead
        DynamicItemDescription.GetComponent<UnityEngine.UI.Text>().text = "";
        //Debug.Log("onMouseExit in InteractiveItem");
    }


    // displays dynamicItemDescription
    public void OnMouseUp()
    {
        DynamicItemDescription.GetComponent<UnityEngine.UI.Text>().text = itemDescription;
        // hmm how to fade the text out after a certain period??
    }
}
