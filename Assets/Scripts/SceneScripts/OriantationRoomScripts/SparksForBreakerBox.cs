using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SparksForBreakerBox : MonoBehaviour
{
    public SpriteRenderer breakerBoxSparks;
    //public GameObject sparksGameObject;
    //Color tmp.a = 0f;

    void Start()
    {
        breakerBoxSparks = GetComponent<SpriteRenderer>();
        // this works but starts on scene load
        //Invoke("ChangeBreakerBoxSparksColor", 0.1f);
    }


    public void ChangeBreakerBoxSparksColor()
    {
        Color tmp = breakerBoxSparks.color;


        if (tmp.a < 0.025f)
        {
            tmp.a = tmp.a = Random.Range(0.0f, 0.1f);
        }
        else if (tmp.a < 0.050f)
        {
            tmp.a = tmp.a = Random.Range(0.0f, 0.1f);
        } 
        else if (tmp.a < 0.075f)
        {
            tmp.a = tmp.a = Random.Range(0.0f, 0.1f);
        } 
        else
        {
            tmp.a = tmp.a = Random.Range(0.0f, 0.1f);
        }

        breakerBoxSparks.color = tmp;

        var randomValue = Random.Range(0.0f, 0.15f);
        // recursive call
        Invoke("ChangeBreakerBoxSparksColor", randomValue);
    }

    //public void TurnOffSparks()
    //{
    //    sparksGameObject.SetActive(false);
    //}
}
