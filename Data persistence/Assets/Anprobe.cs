using UnityEngine;

public class Anprobe : MonoBehaviour
{
    public Figur figur;
    public void AendereHut(int Schrittweite)
    {
        Figur.ausgestattet.hut = Mathf.Clamp(Figur.ausgestattet.hut + Schrittweite, 0, figur.variantenkatalog.huete.Count - 1);
        figur.Sync();
    }
}
