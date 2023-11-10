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


    private int amountOfNumbersEntered = 0;
    private string buttonValue;
    private string theSequenceYouEnteredSoFar = "";

    void Start()
    {
          
    }

    public void EnterKeypadButtonValue()
    {
        buttonValue = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text;



        userEnteredKeyPadCodeSequence[amountOfNumbersEntered] = buttonValue;

        for (int i = 0; i < userEnteredKeyPadCodeSequence.Length; i++)
        {
            theSequenceYouEnteredSoFar += userEnteredKeyPadCodeSequence[i];
            
        }

        Debug.Log("theSequenceYouEnteredSoFar: " + theSequenceYouEnteredSoFar);

        if (amountOfNumbersEntered == 4)
        {
            Debug.Log("theSequenceYouEnteredSoFar: " + theSequenceYouEnteredSoFar);
            CheckIfCorrectCodeWasEntered();
            amountOfNumbersEntered = 0;
            ResetCodeSequenceToAllZeros();
        }
        else
        {
            userEnteredKeyPadCodeSequence[amountOfNumbersEntered] = buttonValue;
            theSequenceYouEnteredSoFar = "";

            /*
            for (int i = 0; i < userEnteredKeyPadCodeSequence.Length; i++)
            {
                theSequenceYouEnteredSoFar += userEnteredKeyPadCodeSequence[i];
            }
            */
            amountOfNumbersEntered++;
            //Debug.Log("theSequenceYouEnteredSoFar: " + theSequenceYouEnteredSoFar);
        }
    }

    private void CheckIfCorrectCodeWasEntered()
    {
        // loop through both keypad code array and user entered array if any are wrong bail out

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

}
