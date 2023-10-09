using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFromGamePlayAreaToInventory : MonoBehaviour
{
    public GameObject KeycardFromPlayArea;
    public GameObject KeycardInInventory;

    private void Start()
    {
        KeycardInInventory.SetActive(false);
    }

    public void TransitionKeycardFromGamePlayAreaToInventory()
    {
        //Debug.Log("TransitionKeycardFromGamePlayAreaToInventory() in ItemFromGameplayAreaToInventory");
        KeycardFromPlayArea.SetActive(false);
        KeycardInInventory.SetActive(true);
    }
}
