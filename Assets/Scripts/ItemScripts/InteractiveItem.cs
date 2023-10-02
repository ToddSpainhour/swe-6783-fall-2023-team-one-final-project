using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewBehaviourScript : MonoBehaviour
{
    // these properties show up in Unity where the values can be entered
    public string itemName = "";
    public string itemDescription = "";
    public bool isInventoryEligible;


    // this creates a slot in Unity to tell this file what GameObject you're talking about
    public GameObject DynamicItemName;
    public GameObject DynamicItemDescription;
    public ItemFromGamePlayAreaToInventory itemFromGamePlayAreaToInventoryScript;


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

        if (this.isInventoryEligible)
        {
            // this conditional is comparing the names over in the Hierarchy
            if(this.name == "keycard-from-play-area")
            {
                //Debug.Log("the item you clicked was named Keycard. Turn this off and turn on the inventory keycard");
                itemFromGamePlayAreaToInventoryScript.TransitionKeycardFromGamePlayAreaToInventory();
            }
        }
    }



}
