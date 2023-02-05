using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Hammer : MonoBehaviour, IPointerClickHandler
{
    [HideInInspector] static public bool isHammer = false;
    [HideInInspector] static public bool isCooldown = false;

    public Texture2D defalutCursor;
    public Texture2D hammerCursor;

    private Vector2 cursorHotSpot = Vector2.zero;

    private void Awake()
    {
        isHammer = false;
        isCooldown = false;
        Cursor.SetCursor(defalutCursor, cursorHotSpot, CursorMode.Auto);
    }
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        //Left Click
        if (pointerEventData.button == PointerEventData.InputButton.Left && isHammer == false)
        {
            isHammer = true;
            Cursor.SetCursor(hammerCursor, cursorHotSpot, CursorMode.Auto);
            Debug.Log("You have a hammer" + isHammer);
        }

        //Right Click
        if (pointerEventData.button == PointerEventData.InputButton.Right && isHammer == true)
        {
            isHammer = false;
            Cursor.SetCursor(defalutCursor, cursorHotSpot, CursorMode.Auto);
            Debug.Log("No Hammer" + isHammer);
        }
    }

    private void Update()
    {
        if (isCooldown)
        {
            var colors = GetComponent<Button>().colors;
            colors.normalColor = Color.red;
            GetComponent<Button>().colors = colors;
        }
        else
        {
            var colors = GetComponent<Button>().colors;
            colors.normalColor = Color.white;
            GetComponent<Button>().colors = colors;
        }
    }
}
