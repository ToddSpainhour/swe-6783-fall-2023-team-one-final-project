using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("FollowMouse just started");
        this.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        HaveIconFollowCursor();
    }

    public void HaveIconFollowCursor()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
        transform.position = mousePosition;
    }
}
