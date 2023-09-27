using UnityEngine;
using UnityEngine.EventSystems;

public class CursorManager : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Texture2D cursorCircleTransparentWhite;
    public Texture2D cursorPlusSignTransparentWhite;

    public void Start()
    {
    }

    public void OnInteractiveItemCursorEnter()
    {
        // change to the circle cursor
        Cursor.SetCursor(cursorCircleTransparentWhite, Vector2.zero, CursorMode.Auto);
    }

    public void OnInteractiveItemCursorLeave()
    {
        // change back to plus sign cursor
        Cursor.SetCursor(cursorPlusSignTransparentWhite, Vector2.zero, CursorMode.Auto);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter2D");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("OnPointerEnter");
        Cursor.SetCursor(cursorCircleTransparentWhite, Vector2.zero, CursorMode.Auto);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("onpointerExit");
        Cursor.SetCursor(cursorPlusSignTransparentWhite, Vector2.zero, CursorMode.Auto);
    }
}
