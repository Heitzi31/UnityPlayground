using UnityEngine;
using UnityEngine.EventSystems;

public class Ebene : MonoBehaviour , IPointerClickHandler
{
    public GameObject Spielfigur;
    public void OnPointerClick(PointerEventData eventData)
    {
       Vector3 zielPosition = new Vector3(eventData.pointerCurrentRaycast.worldPosition.x, eventData.pointerCurrentRaycast.worldPosition.y, eventData.pointerCurrentRaycast.worldPosition.z);
       Spielfigur spielfigur = Object.FindFirstObjectByType<Spielfigur>();
       spielfigur.GeheZu(zielPosition);    
    }
}
