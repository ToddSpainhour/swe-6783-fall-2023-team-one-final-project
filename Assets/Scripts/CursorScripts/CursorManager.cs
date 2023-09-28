using UnityEngine;
using UnityEngine.EventSystems;

public class CursorManager : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Texture2D cursorCircleTransparentWhite;
    public Texture2D cursorPlusSignTransparentWhite;


    public void OnPointerEnter(PointerEventData eventData)
    {
        Cursor.SetCursor(cursorCircleTransparentWhite, Vector2.zero, CursorMode.Auto);
        Debug.Log("OnPointerEnter in CursorManager");
    }


    public void OnPointerExit(PointerEventData eventData)
    {
        Cursor.SetCursor(cursorPlusSignTransparentWhite, Vector2.zero, CursorMode.Auto);
        Debug.Log("onPointerExit in CursorManager");
    }
}
