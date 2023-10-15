using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlovesToInventory : MonoBehaviour
{
    public GameObject GlovesFromPlayArea;
    public GameObject GlovesInInventory;

    private void Start()
    {
        GlovesInInventory.SetActive(false);
    }

    public void TransitionGlovesFromGamePlayAreaToInventory()
    {
        GlovesFromPlayArea.SetActive(false);
        GlovesInInventory.SetActive(true);
    }
}
