using UnityEngine;
using UnityEngine.EventSystems;

public class Fichte : MonoBehaviour, IPointerClickHandler
{
    public GameObject transporter;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (Vector3.Distance(transporter.transform.position, transform.position) < 5)
        {
            Transporter transporterScript = transporter.GetComponent<Transporter>();
            if (transporterScript.currentStammNumber < 5)
            {
                Debug.Log(name + " wurde angeklickt.");
                transporterScript.Beladen();
                Destroy(gameObject);
            }
        }
    }

}