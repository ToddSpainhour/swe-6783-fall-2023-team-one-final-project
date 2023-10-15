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
    public GlovesToInventory glovesToInventoryScript;


    // displays dynamicItemName
    public void OnMouseEnter()
    {
        DynamicItemName.GetComponent<UnityEngine.UI.Text>().text = itemName;
    }


    // clears out dynamicItemName and dynamicItemDesciption
    public void OnMouseExit()
    {

        DynamicItemName.GetComponent<UnityEngine.UI.Text>().text = "";
        DynamicItemDescription.GetComponent<UnityEngine.UI.Text>().text = "";
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
                itemFromGamePlayAreaToInventoryScript.TransitionKeycardFromGamePlayAreaToInventory();
            } 
            else if(this.name == "GlovesInGameArea")
            {
                glovesToInventoryScript.TransitionGlovesFromGamePlayAreaToInventory();
            }
        }
    }
}
