using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;

public class Vase : MonoBehaviour, IPointerClickHandler
{
    public GameObject[] VasenArray;
    public Figur beobchter;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (beobchter.siehtVase)
        {
            Zerstoeren();
        }
        else
        {
            Debug.Log("Du musst näher an die Vase, um sie zu zerstören!");
        }
    }

    public void Zerstoeren()
    {
        Debug.Log("Vase wurde zerstört!");
        Instantiate(VasenArray[0], transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
