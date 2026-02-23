using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class FirstPersonCam : MonoBehaviour
{
    public Transform kopf;
    public Transform ritter;
    private Quaternion kopfAusgangsPose;
    private Quaternion koerperAusgangsPose;
    private void Start()
    {
        kopfAusgangsPose = kopf.localRotation;
        koerperAusgangsPose = ritter.transform.localRotation;
    }
    public float winkelProSec = 100f;
    private float nickWinkel = 0f;
    private float gierWinkel = 0f;
    private void Update()
    {
        if(Mouse.current.rightButton.isPressed)
        {

            float horz = Mouse.current.delta.x.value * Time.deltaTime * winkelProSec;  
            float vert = Mouse.current.delta.y.value * Time.deltaTime * winkelProSec;
            nickWinkel += vert;
            gierWinkel += horz;

            nickWinkel = Mathf.Clamp(nickWinkel, -35f, 35f);
            gierWinkel = Mathf.Clamp(gierWinkel, -55, 55f);

            kopf.transform.localRotation = Quaternion.AngleAxis(nickWinkel, Vector3.right) * kopfAusgangsPose;
            ritter.transform.localRotation = Quaternion.AngleAxis(gierWinkel, Vector3.up) * koerperAusgangsPose;
        }
    }
}
