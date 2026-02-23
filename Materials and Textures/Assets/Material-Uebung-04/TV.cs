using Mono.Cecil.Cil;
using UnityEngine;
using UnityEngine.Video;

public class TV : MonoBehaviour
{
    public Material Gewonnen;
    public VideoPlayer videoPlayer;
    public MeshRenderer meshrenderer;
    public Material Testbildschirm;

    string s = "";
    public void Umschalten(Material mat)
    {
        Debug.Log(name + " wurde gedrückt");
        meshrenderer.sharedMaterial = mat;
        Debug.Log(mat.name[1]);
        s+= mat.name[1];
        Debug.Log(s);

        if (s.Length == 4 && s.Contains("oerl"))
        {
            Debug.Log("Korrekter Code");
            meshrenderer.sharedMaterial = Gewonnen;
            videoPlayer.Play();

        }
        else if (s.Length == 4 & !s.Contains("oerl"))
        {
            Debug.Log("Falscher Code, versuche es erneut :)");
            s = "";
            meshrenderer.sharedMaterial = Testbildschirm;
            
        }

    }
}
