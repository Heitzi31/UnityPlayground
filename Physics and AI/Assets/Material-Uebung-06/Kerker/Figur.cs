using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class Figur : MonoBehaviour
{
    private NavMeshAgent agent;
    public bool siehtVase;
    public Transform[] vaseziele;
    private Vase[] vasen;
    public float maxDistanz = 3f;

    [Range(0,360f)]
    public float blickWinkel=80f;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        vasen = FindObjectsOfType<Vase>(); 
        vaseziele = new Transform[vasen.Length];
        for (int i = 0; i < vasen.Length; i++)
        {
            vaseziele[i] = vasen[i].transform;
        }
    }

    private void Update()
    {
        SiehtVase();

        if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.value);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                agent.destination = hit.point;
            }
        }
        
    }
    public void SiehtVase()
    {
        siehtVase = false;
        if (vaseziele == null || vaseziele.Length == 0) return;

        foreach (var ziel in vaseziele)
        {
            if (ziel == null) continue;
            float distanz = Vector3.Distance(transform.position, ziel.position);
            if (distanz > maxDistanz)
            {
                Debug.DrawLine(transform.position, ziel.position, Color.green);
                continue;
            }

            Vector3 richtungZurVase = (ziel.position - transform.position).normalized;
            float winkel = Vector3.Angle(transform.forward, richtungZurVase);
            if (winkel < blickWinkel / 2f)
            {
                siehtVase = true;
                Debug.Log("Die Figur sieht eine Vase!");
                Debug.DrawLine(transform.position, ziel.position, Color.red);
                break; 
            }
            else
            {
                Debug.DrawLine(transform.position, ziel.position, Color.blue);
            }
        }

        Vector3 linkerAußenwinkel = Quaternion.Euler(0, -blickWinkel / 2f, 0) * transform.forward * maxDistanz;
        Debug.DrawLine(transform.position, transform.position + linkerAußenwinkel);
        Vector3 rechterAußenwinkel = Quaternion.Euler(0, blickWinkel / 2f, 0) * transform.forward * maxDistanz;
        Debug.DrawLine(transform.position, transform.position + rechterAußenwinkel);
        Vector3 mitte = transform.forward * maxDistanz;
        Debug.DrawLine(transform.position, transform.position + mitte);
    }
}
