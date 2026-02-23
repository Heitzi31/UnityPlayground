using UnityEngine;

public class Transporter : MonoBehaviour
{
    public void Beladen()
    {
        Debug.Log("Jetzt beladen!");
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Beladen();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
