using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class MuseumKeypadScript : MonoBehaviour
{
    static string[] KeypadCode = { "4", "3", "1", "1", "2" };
    static string[] userEnteredKeyPadCodeSequence = { "0", "0", "0", "0", "0" };

    private int amountOfNumbersEntered = 0;
    private string buttonValue;

    public GameObject keyPadLight1;
    public GameObject keyPadLight2;
    public GameObject keyPadLight3;
    public GameObject keyPadLight4;
    public GameObject keyPadLight5;

    AdvanceThroughMuseum advanceThroughMuseumScript;

    private void Start()
    {
        advanceThroughMuseumScript = FindObjectOfType<AdvanceThroughMuseum>();
    }

    public void EnterKeypadButtonValue()
    {
        buttonValue = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text;
        userEnteredKeyPadCodeSequence[amountOfNumbersEntered] = buttonValue;

        if (amountOfNumbersEntered == 4)
        {
            ChangeKeypadLightColor();
            CheckIfCorrectCodeWasEntered();
            amountOfNumbersEntered = 0;
            ResetCodeSequenceToAllZeros();
        }
        else
        {
            userEnteredKeyPadCodeSequence[amountOfNumbersEntered] = buttonValue;
            ChangeKeypadLightColor();
            amountOfNumbersEntered++;
        }
    }


    private void CheckIfCorrectCodeWasEntered()
    {

        bool wasCorrectCodeEntered = false; 

        for(int i = 0; i < userEnteredKeyPadCodeSequence.Length; i++)
        {
            if (userEnteredKeyPadCodeSequence[i] != KeypadCode[i])
            {
                wasCorrectCodeEntered = false;
                ChangeAllKeyPadLightsToYellow();
                return;
            }
            wasCorrectCodeEntered = true;
        }

        if(wasCorrectCodeEntered)
        {
            advanceThroughMuseumScript.OpenHiddenDoor();
        }


        Debug.Log("correct code!!");
    }


    private void ChangeKeypadLightColor()
    {
        // if the key pad number entered is equal the correct value turn the light green
        if (userEnteredKeyPadCodeSequence[amountOfNumbersEntered] == KeypadCode[amountOfNumbersEntered])
        {
            switch (amountOfNumbersEntered)
            {
                case 0:
                    keyPadLight1.GetComponent<Renderer>().material.color = Color.green;
                    break;
                case 1:
                    keyPadLight2.GetComponent<Renderer>().material.color = Color.green;
                    break;
                case 2:
                    keyPadLight3.GetComponent<Renderer>().material.color = Color.green;
                    break;
                case 3:
                    keyPadLight4.GetComponent<Renderer>().material.color = Color.green;
                    break;
                case 4:
                    keyPadLight5.GetComponent<Renderer>().material.color = Color.green;
                    break;
                default:
                    break;
            }
        } 
        else
        {
            // if the value entered is not correct make light red
            switch (amountOfNumbersEntered)
            {
                case 0:
                    keyPadLight1.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case 1:
                    keyPadLight2.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case 2:
                    keyPadLight3.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case 3:
                    keyPadLight4.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case 4:
                    keyPadLight5.GetComponent<Renderer>().material.color = Color.red;
                    break;
                default:
                    break;
            }
        }
    }


    private void ResetCodeSequenceToAllZeros()
    {
        for (int i = 0; i < userEnteredKeyPadCodeSequence.Length; i++)
        {
            userEnteredKeyPadCodeSequence[i] = "0";
        }
    }


    private void ChangeAllKeyPadLightsToYellow()
    {
        keyPadLight1.GetComponent<Renderer>().material.color = Color.yellow;
        keyPadLight2.GetComponent<Renderer>().material.color = Color.yellow;
        keyPadLight3.GetComponent<Renderer>().material.color = Color.yellow;
        keyPadLight4.GetComponent<Renderer>().material.color = Color.yellow;
        keyPadLight5.GetComponent<Renderer>().material.color = Color.yellow;
    }
}
