using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    void Start()
    {
        Debug.Log("FollowMouse just started");
    }


    void Update()
    {
        HaveIconFollowCursor();
    }


    public void HaveIconFollowCursor()
    {
        this.enabled = true;
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
        transform.position = mousePosition;
    }
}
