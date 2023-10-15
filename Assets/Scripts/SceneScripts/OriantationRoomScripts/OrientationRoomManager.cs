using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationRoomManager : MonoBehaviour
{

    public GameObject tvScreenOff;
    public GameObject tvOffHotspot;

    public GameObject tvScreenOn;
    public GameObject tvOnHotspot;

    public GameObject breakerBoxClosed;
    public GameObject breakerBoxClosedHotspot;

    public GameObject breakerBoxOpen;
    public GameObject breakerBoxOpenHotspot;

    public GameObject elevatorClosed;
    public GameObject elevatorClosedHotspot;

    public GameObject elevatorOpen;
    public GameObject elevatorOpenHotspot;


    public ChangePaperColor changePaperColorScript;
    public SparksForBreakerBox sparksForBreakerBoxScript;
    public GameObject sparks;

    void Start()
    {
        Invoke("PowerDownOrientationRoom", 10f);
    }

    public void PowerDownOrientationRoom()
    {

        // make paper texture darker/aka power went out
        changePaperColorScript.MakePaperTextureDarker();

        // turn off tv screen
        tvScreenOn.SetActive(false);
        // show tv black screen
        tvScreenOff.SetActive(true);

        tvOnHotspot.SetActive(false);
        tvOffHotspot.SetActive(true);

        // turn off closed breaker box art asset
        breakerBoxClosed.SetActive(false);
        // turn off closed breaker box hotspot
        breakerBoxClosedHotspot.SetActive(false);
        // turn on breakerbox open hotspot
        breakerBoxOpenHotspot.SetActive(true);
        // show open breaker box art asset
        breakerBoxOpen.SetActive(true);

        sparksForBreakerBoxScript.ChangeBreakerBoxSparksColor();


        // harcoded was to power room back up; this action will be player controlled
        // Invoke("PowerUpOrientationRoom", 4f);
    }

    public void PowerUpOrientationRoom()
    {
        changePaperColorScript.MakePaperTextureNormalBrightness();
        elevatorClosed.SetActive(false);
        elevatorClosedHotspot.SetActive(false);
        elevatorOpen.SetActive(true);
        elevatorOpenHotspot.SetActive(true);
        tvScreenOff.SetActive(false);
        tvScreenOn.SetActive(true);
        tvOnHotspot.SetActive(true);
        tvOffHotspot.SetActive(false);
        sparks.SetActive(false);
    }
}
