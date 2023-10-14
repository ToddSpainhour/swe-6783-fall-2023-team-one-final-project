using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationRoomManager : MonoBehaviour
{

    public GameObject tvScreenOff;
    public GameObject breakerBoxClosed;
    public GameObject breakerBoxOpen;
    public GameObject elevatorClosed;
    public GameObject elevatorOpen;

    //private SpriteRenderer paperTextureSprite;

    public ChangePaperColor changePaperColorScript;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("PowerDownOrientationRoom", 5f);
    }

    public void PowerDownOrientationRoom()
    {
        Debug.Log("Power Lost!");

        //var ren = changePaperColorScript.GetComponent<SpriteRenderer>();
        //ren.gameObject.activeSelf
        changePaperColorScript.MakePaperTextureDarker();

        tvScreenOff.SetActive(true);
        breakerBoxClosed.SetActive(false);
        breakerBoxOpen.SetActive(true);



        Invoke("PowerUpOrientationRoom", 4f);
    }

    public void PowerUpOrientationRoom()
    {
        changePaperColorScript.MakePaperTextureNormalBrightness();

        Debug.Log("Power Restored!");
        elevatorClosed.SetActive(false);
        elevatorOpen.SetActive(true);
        tvScreenOff.SetActive(false);
    }
}
