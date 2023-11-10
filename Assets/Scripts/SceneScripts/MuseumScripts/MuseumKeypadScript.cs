using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class MuseumKeypadScript : MonoBehaviour
{

    static string[] KeypadCode = { "4", "3", "1", "1", "2" };
    //static List<string> userEnteredKeyPadCodeSequence = new List<string> { "0", "0", "0", "0", "0" };
    static string[] userEnteredKeyPadCodeSequence = { "0", "0", "0", "0", "0" };
    public GameObject keyPadLight1;
    public GameObject keyPadLight2;
    public GameObject keyPadLight3;
    public GameObject keyPadLight4;
    public GameObject keyPadLight5;

    private int amountOfNumbersEntered = 0;
    private string buttonValue;
    private string theSequenceYouEnteredSoFar = "";

    public void EnterKeypadButtonValue()
    {
        buttonValue = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text;
        userEnteredKeyPadCodeSequence[amountOfNumbersEntered] = buttonValue;

        for (int i = 0; i < userEnteredKeyPadCodeSequence.Length; i++)
        {
            theSequenceYouEnteredSoFar += userEnteredKeyPadCodeSequence[i]; 
        }

        //Debug.Log("theSequenceYouEnteredSoFar: " + theSequenceYouEnteredSoFar);

        if (amountOfNumbersEntered == 4)
        {
            ChangeKeypadLightColor();
            Debug.Log("theSequenceYouEnteredSoFar: " + theSequenceYouEnteredSoFar);
            CheckIfCorrectCodeWasEntered();
            amountOfNumbersEntered = 0;
            ResetCodeSequenceToAllZeros();
        }
        else
        {
            userEnteredKeyPadCodeSequence[amountOfNumbersEntered] = buttonValue;
            theSequenceYouEnteredSoFar = "";
            ChangeKeypadLightColor();
            amountOfNumbersEntered++;
        }
    }

    private void CheckIfCorrectCodeWasEntered()
    {
        for(int i = 0; i < userEnteredKeyPadCodeSequence.Length; i++)
        {
            if (userEnteredKeyPadCodeSequence[i] != KeypadCode[i])
            {
                Debug.Log("wrong code");
                return;
            }        
        }
        Debug.Log("correct code!!");
    }

    private void ResetCodeSequenceToAllZeros()
    {
        for (int i = 0; i < userEnteredKeyPadCodeSequence.Length; i++)
        {
            userEnteredKeyPadCodeSequence[i] = "0";
        }
    }

    private void ChangeKeypadLightColor()
    {
        Debug.Log("userEnteredKeyPadCodeSequence[amountOfNumbersEntered] " + userEnteredKeyPadCodeSequence[amountOfNumbersEntered]);
        Debug.Log("KeypadCode[amountOfNumbersEntered] " + KeypadCode[amountOfNumbersEntered]);
        // if the number entered equal the number at the same index, turn the light green
        if (userEnteredKeyPadCodeSequence[amountOfNumbersEntered] == KeypadCode[amountOfNumbersEntered])
        {
            switch (amountOfNumbersEntered)
            {
                // case is the index position
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
                    Debug.Log("inside deafult case statement");
                    break;
            }
        }
    }
}
