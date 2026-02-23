using UnityEngine;
using UnityEngine.EventSystems;

public class Fichte : MonoBehaviour, IPointerClickHandler
{
    public GameObject Transporter;
    private void OnMouseUp()
    {
        GameObject kopie = Instantiate(this.gameObject);
        kopie.transform.position += new Vector3(1.5f, 0f, 0f);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Destroy(this.gameObject);
        Debug.Log("Fichte wurde gefällt :( ");
        Transporter.GetComponent<Transporter>().Beladen();  
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
