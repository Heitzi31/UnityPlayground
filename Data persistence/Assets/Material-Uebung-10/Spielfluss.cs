using UnityEngine;
using UnityEngine.SceneManagement;

public class Spielfluss : MonoBehaviour
{
    public string SampleScene;

    // Update is called once per frame
    public void GeheZu()
    {
        SceneManager.LoadScene(SampleScene);
    }
    
}
