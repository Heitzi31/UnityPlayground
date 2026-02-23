using UnityEngine;
using UnityEngine.InputSystem;

public class SecondPersonCam : MonoBehaviour
{
    private Vector3 dragOrigin;
    private void Update()
    {
        if (Mouse.current.leftButton.isPressed) //Solange Maus gedrückt
        {
            if (Mouse.current.leftButton.wasPressedThisFrame) //Bei erstem Ereignis Startpos merken
                dragOrigin = Camera.main.ScreenToWorldPoint(Mouse.current.position.value);
            Vector3 diff = dragOrigin - Camera.main.ScreenToWorldPoint(Mouse.current.position.value);
            Camera.main.transform.position += diff;

        }
        if(Keyboard.current.upArrowKey.isPressed) 
        {
            Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize - 0.1f, 3f,10f);
        }

        if(Keyboard.current.downArrowKey.isPressed)
        {
            Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize + 0.1f, 3f,10f);
        }
    }
}

