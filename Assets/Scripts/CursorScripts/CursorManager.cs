using UnityEngine;
using UnityEngine.EventSystems;

public class CursorManager : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Texture2D cursorCircleTransparentWhite;
    public Texture2D cursorPlusSignTransparentWhite;


    public void OnPointerEnter(PointerEventData eventData)
    {
        Vector2 hotspot = new Vector2(cursorCircleTransparentWhite.width / 2f, cursorCircleTransparentWhite.height / 2f);
        Cursor.SetCursor(cursorCircleTransparentWhite, hotspot, CursorMode.Auto);
    }


    public void OnPointerExit(PointerEventData eventData)
    {
        Vector2 hotspot = new Vector2(cursorPlusSignTransparentWhite.width / 2f, cursorPlusSignTransparentWhite.height / 2f);
        Cursor.SetCursor(cursorPlusSignTransparentWhite, hotspot, CursorMode.Auto);
    }
}
