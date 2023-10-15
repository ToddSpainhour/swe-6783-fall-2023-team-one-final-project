using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePaperColor : MonoBehaviour
{

    public Color powerOffColor;
    public Color powerOnColor;
    private SpriteRenderer paperTextureSpriteRenderer;
    public SpriteRenderer paperTexture;
    //private bool isPoweredDownColor;


    public void Start()
    {
        paperTextureSpriteRenderer = GetComponent<SpriteRenderer>();
    }


    public void MakePaperTextureDarker()
    {
        paperTextureSpriteRenderer.color = powerOffColor;
    }


    public void MakePaperTextureNormalBrightness()
    {
        paperTextureSpriteRenderer.color = powerOnColor;
    }

}
