using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour
{
    [SerializeField] private GameObject joystick;
    [SerializeField] private GameObject joystickBg;
    public Vector2 _joystickVec; 
    private Vector2 _joystickTouchPos; 
    private Vector2 _joystickOriginalPos;
    private float _joystickRadius;

    private void Start()
    {
        _joystickOriginalPos = joystick.transform.position;
        _joystickRadius = joystickBg.GetComponent<RectTransform>().sizeDelta.y / 4;
    }

    public void PointerDown()
    {
        joystick.transform.position = Input.mousePosition;
        joystickBg.transform.position = Input.mousePosition;
        _joystickTouchPos = Input.mousePosition;
    }

    public void Drag(BaseEventData baseEventData)
    {
        var pointerEventData = baseEventData as PointerEventData;
        var dragPos = pointerEventData.position;
        _joystickVec = (dragPos - _joystickTouchPos).normalized;
        
        float joystickDist = Vector2.Distance(dragPos, _joystickTouchPos);

        if (joystickDist < _joystickRadius)
        {
            joystick.transform.position = _joystickTouchPos + _joystickVec * joystickDist;
        }
        else
        {
            joystick.transform.position = _joystickTouchPos + _joystickVec * _joystickVec;
        }
    }

    public void PointerUp()
    {
        _joystickVec = Vector2.zero;
        joystick.transform.position = _joystickOriginalPos;
        joystickBg.transform.position = _joystickOriginalPos;
    }
}    