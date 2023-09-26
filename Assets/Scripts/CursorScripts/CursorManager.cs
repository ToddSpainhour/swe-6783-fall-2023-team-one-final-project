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
        Debug.Log("--> OnInteractiveItemCursorEnter() just fired!");
        Cursor.SetCursor(cursorCircleTransparentWhite, Vector2.zero, CursorMode.Auto);
    }

    public void OnInteractiveItemCursorLeave()
    {
        // change back to plus sign cursor
        Debug.Log("--> OnInteractiveItemCursorLeave() just fired!");
        Cursor.SetCursor(cursorPlusSignTransparentWhite, Vector2.zero, CursorMode.Auto);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter2D just fired");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {


        Cursor.SetCursor(cursorCircleTransparentWhite, Vector2.zero, CursorMode.Auto);
        //Debug.Log("onpointerenter");
        Debug.Log("OnPointerEnter gameObject: ", this.gameObject);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Cursor.SetCursor(cursorPlusSignTransparentWhite, Vector2.zero, CursorMode.Auto);
        //Debug.Log("onpointerExit");
        Debug.Log("onpointerExit GameObject: ", gameObject);
    }
}
