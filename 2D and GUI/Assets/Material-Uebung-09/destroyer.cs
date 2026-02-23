using UnityEngine;

public class destroyer : MonoBehaviour
{
    public void destroy()
    {
        Debug.Log("Zerstört");
        Destroy(gameObject);
    }
}
