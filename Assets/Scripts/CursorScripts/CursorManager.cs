using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public Texture2D cursorCircleTransparentWhite;
    public Texture2D cursorPlusSignTransparentWhite;

    public void Start()
    {
    }

    public void OnInteractiveItemCursorEnter()
    {
        // change to the circle cursor
        Debug.Log("--> OnInteractiveItemCursorEnter() just fired!");
        Cursor.SetCursor(cursorCircleTransparentWhite, Vector2.zero, CursorMode.Auto);
    }

    public void OnInteractiveItemCursorLeave()
    {
        // change back to plus sign cursor
        Debug.Log("--> OnInteractiveItemCursorLeave() just fired!");
        Cursor.SetCursor(cursorPlusSignTransparentWhite, Vector2.zero, CursorMode.Auto);
    }
}
