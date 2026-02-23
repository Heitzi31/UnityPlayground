using UnityEngine;
using UnityEngine.EventSystems;

public class Knopf : MonoBehaviour,IPointerClickHandler
{
   
    public GameObject TV;
    public MeshRenderer meshrenderer;
    private void Start()
    {
        meshrenderer = GetComponent<MeshRenderer>();
        
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        TV.GetComponent<TV>().Umschalten(meshrenderer.sharedMaterial);  
    }
}


