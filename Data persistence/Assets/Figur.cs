using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;
using System.IO;

public class Figur : MonoBehaviour
{
    public Variantenkatalog variantenkatalog;
    public GameObject aktuellerHut;
    public static Ausstattung ausgestattet = new Ausstattung();
    public string savegamepfad;

    public void Sync()
    {   
        GameObject alterHut = aktuellerHut;
        Destroy(alterHut);
        GameObject neuerHut = variantenkatalog.huete[ausgestattet.hut];
        aktuellerHut = Instantiate(neuerHut, transform);
    }

    public void Speichern()
    {
        string Ausstattung = JsonUtility.ToJson(ausgestattet);
        File.WriteAllText(savegamepfad,Ausstattung);
    }

    private void Start()
    {
        savegamepfad = Path.Combine(Application.persistentDataPath, "savegame.json");
        Debug.Log("Speichere Spielstand in: " + savegamepfad);
        if (File.Exists(savegamepfad))
        {
            string gespeicherteAusstattung = File.ReadAllText(savegamepfad);
            ausgestattet = JsonUtility.FromJson<Ausstattung>(gespeicherteAusstattung);
        }
        Sync();
    }
}
