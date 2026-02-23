using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Truck : MonoBehaviour
{
    //private InputAction moveEingabe;
    [Range(1, 100)]
    public int geschwindigkeit = 3;
    Vector2 input = Vector2.zero;

    private void OnMove(InputValue value)
    {
        input = value.Get<Vector2>();
    }


    // Update is called once per frame
    public void Update()
    {
       transform.Translate(Vector3.forward * input.y * geschwindigkeit * Time.deltaTime);
       transform.Rotate(0, input.x * input.y * Time.deltaTime * geschwindigkeit * 10, 0);
    }
}


