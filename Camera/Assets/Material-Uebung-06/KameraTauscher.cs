using UnityEngine;
using UnityEngine.InputSystem;

public class KameraTauscher : MonoBehaviour
{
    public GameObject ersteP;
    public GameObject zweiteP;
    public GameObject dritteP;

    private void Update()
    {
        if(Keyboard.current.digit1Key.wasPressedThisFrame)
        {
            ersteP.SetActive(true);
            zweiteP.SetActive(false);
            dritteP.SetActive(false);
        }
        if(Keyboard.current.digit2Key.wasPressedThisFrame)
        {
            ersteP.SetActive(false);
            zweiteP.SetActive(true);
            dritteP.SetActive(false);
        }   
        if(Keyboard.current.digit3Key.wasPressedThisFrame)
        {
            ersteP.SetActive(false);
            zweiteP.SetActive(false);
            dritteP.SetActive(true);
        }
    }
}
