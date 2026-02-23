using UnityEngine;

public class Spielfigur : MonoBehaviour
{ 
    
    string DstartAni = "DaniStartet";
    string DendAni = "DaniFertig";
    string LstartAni = "LaniStartet";
    string LendAni = "LaniFertig";
    public Animator anim;

    public void GeheZu(Vector3 zielPosition)
    {  
        iTween.LookTo(gameObject, iTween.Hash("looktarget", zielPosition, "time", 1f, "onstart", DstartAni, "oncomplete", DendAni));
        iTween.MoveTo(gameObject, iTween.Hash("position", zielPosition, "speed", 3f, "onstart", LstartAni, "oncomplete", LendAni, "easetype" , "easeInOutQuad"));
    } 

    private void DaniStartet()
    { 
        Debug.Log(" Dreh-Animation startet");
    }
    private void DaniFertig()
    {   
        Debug.Log("Dreh-Animation fertig");
    }
    private void LaniStartet()
    {
        Debug.Log(" Lauf-Animation startet");
        anim.SetBool("inBewegung", true);
    }
    private void LaniFertig()
    {
        Debug.Log("Lauf-Animation fertig");
        anim.SetBool("inBewegung", false);
    }
}
