using UnityEngine;
using UnityEngine.InputSystem;


public class Truck : MonoBehaviour
{

    [Range(1f, 100f)]
    public float speed = 5f;
    public float rotspeed = 100f;

    private InputAction moveEingabe;

    void Start()
    {
        moveEingabe = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    private void Update()
    {
        //forward();

        Bewegung();
        //Debug.Log(moveEingabe.ReadValue<Vector2>());
    }


    public void forward()
    {
        transform.position += transform.forward * (speed * Time.deltaTime);
    }

    public void Bewegung()
    {
        Vector2 move = moveEingabe.ReadValue<Vector2>();
        transform.Translate(Vector3.forward * move.y * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * move.x * move.y * rotspeed * Time.deltaTime);

    }
}

//using Unity.VisualScripting;
//using UnityEngine;
//using UnityEngine.InputSystem;

//public class Truck : MonoBehaviour
//{
//    //private InputAction moveEingabe;
//    [Range(1, 100)]
//    int geschwindigkeit = 10;
//    Vector2 input = Vector2.zero;

//    private void OnMove(InputValue value)
//    {
//        input = value.Get<Vector2>();
//    }


//    public void Start()
//    {
//    }

//    // Update is called once per frame
//    public void Update()
//    {
//        transform.Translate(Vector3.forward * input.y * geschwindigkeit * Time.deltaTime);
//        transform.Rotate(0, input.x * input.y * Time.deltaTime * geschwindigkeit * 10, 0);
//        Debug.Log(input);
//    }
//}