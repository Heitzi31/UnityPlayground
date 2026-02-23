using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Laserkanone : MonoBehaviour
{
    public GameObject laserkanone;
    public GameObject ziel;
    public Vector3 versatz;
    public float distanz = 30f;
    RaycastHit hit;
    private LineRenderer lr;
    private Light ziellicht;
    private void Start()
    {
        lr = GetComponent<LineRenderer>();
        Light muzzleflash = laserkanone.GetComponentInChildren<Light>();
        ziellicht = ziel.GetComponentInChildren<Light>();

        Gradient gradient = new Gradient();
        gradient.SetKeys(
            new GradientColorKey[] { new GradientColorKey(muzzleflash.color, 0.0f), new GradientColorKey(ziellicht.color, 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(muzzleflash.intensity, 0.0f), new GradientAlphaKey(ziellicht.intensity, 1.0f) }
        );
        lr.colorGradient = gradient;
    }
    private void Update()
    {
        
        laser(hit);

        Vector3 debuglinie = transform.forward * distanz;
        if (Physics.Raycast(transform.position, transform.forward, out hit, distanz))
        {
           
            Debug.Log("Ziel getroffen!");
            Debug.DrawLine(transform.position + versatz, transform.position + debuglinie, Color.red);
        }
        else
            Debug.DrawLine(transform.position + versatz, transform.position + debuglinie, Color.white);

    }

    private void laser(RaycastHit pHit)
    {
        if (pHit.collider != null)
        {
            lr.SetPosition(1, Vector3.forward * pHit.distance); 
            ziellicht.enabled = true;
        }
        else
        {
            lr.SetPosition(1, Vector3.forward * distanz);
            ziellicht.enabled = false;
        }
    }
}
