using UnityEngine;


public class Pflanze : MonoBehaviour
{
    private Vector3 start = new Vector3(0f, 0f, 0f);
    private Vector3 wachsen = new Vector3(1f, 1f, 1f);

    private float Wspeed = 0f;
    private float Sspeed = 0f;

    private bool wargross = false;
    private bool warten = false;

    private float Wartetimer = 0f;
    private float Wartezeit = 3f;
    private void Start()
    {   
        Wspeed = Random.value * -3;
    }

    private void Update()
    {
        if (warten==false)
         transform.localScale = Vector3.Lerp(start, wachsen, Wspeed += Time.deltaTime);
        
        if (transform.localScale.x == 1)
         warten = true;
        
        if (warten)
        {
            Wartetimer += Time.deltaTime;
            transform.localScale = wachsen;
            if (Wartetimer >= Wartezeit)
            {
                warten = false;
                wargross = true;
            }
        }

        if (wargross)
        {
            transform.localScale = Vector3.Lerp(wachsen, start, Sspeed += Time.deltaTime);
            if (transform.localScale.x == 0)
            {
                warten = false;
                wargross = false;
                Wspeed = Random.value * -3;
                Sspeed = 0f;
                Wartetimer = 0f;
            }
        }
    }   
}

