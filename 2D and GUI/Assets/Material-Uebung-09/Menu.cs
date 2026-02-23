using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Neustart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
