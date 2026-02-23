using UnityEngine;

public class Stein : MonoBehaviour
{
    public Bibliothek bibliothek;
    public Color farbe;
    public Sprite symbol;
    private SpriteRenderer ersteller;
    

    private void Start()
    {
        int symbol = Random.Range(0, bibliothek.symbole.Length);
        this.symbol = bibliothek.symbole[symbol];

        int color = Random.Range(0, bibliothek.farben.Length);
        this.farbe = bibliothek.farben[color];

        ersteller = transform.Find("symbol").GetComponentInChildren<SpriteRenderer>();
        ersteller.sprite = this.symbol;
        ersteller.color = this.farbe;

      
    }

    // Update is called once per frame
    private void Update()
    {

    }
}
