using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    bool gameover = false;
    bool gedrückt = false; 

    string[,] buttons; 

    [Range(2, 100)] 
    public int SpielFeldBreite = 3;

    bool pruefeLoesung()
    {         // Horizontal
        for (int y = 0; y < SpielFeldBreite; y++)
        {
            bool gewonnen = true;
            for (int x = 1; x < SpielFeldBreite; x++)
            {
                if (buttons[x, y] != buttons[0, y] || buttons[x, y] == null)
                {
                    gewonnen = false;
                    break;
                }
            }
            if (gewonnen) return true;
        }
        // Vertikal
        for (int x = 0; x < SpielFeldBreite; x++)
        {
            bool gewonnen = true;
            for (int y = 1; y < SpielFeldBreite; y++)
            {
                if (buttons[x, y] != buttons[x, 0] || buttons[x, y] == null)
                {
                    gewonnen = false;
                    break;
                }
            }
            if (gewonnen) return true;
        }
        // Diagonal links oben nach rechts unten
        bool diagonalGewonnen = true;
        for (int i = 1; i < SpielFeldBreite; i++)
        {
            if (buttons[i, i] != buttons[0, 0] || buttons[i, i] == null)
            {
                diagonalGewonnen = false;
                break;
            }
        }
        if (diagonalGewonnen) return true;
        // Diagonal rechst oben nach links unten
        diagonalGewonnen = true;
        for (int i = 1; i < SpielFeldBreite; i++)
        {
            if (buttons[SpielFeldBreite - 1 - i, i] != buttons[SpielFeldBreite - 1, 0] || buttons[SpielFeldBreite - 1 - i, i] == null)
            {
                diagonalGewonnen = false;
                break;
            }
        }
        if (diagonalGewonnen) return true;
        return false;
    }

    void spielrum() 
    {
        if (gameover == true )
        {
            GUI.color = Color.green;
            GUI.Label(new Rect(5, 5, 70, 30), "Gewonnen");
            GUI.color = Color.white;
            GUI.enabled = false;
        }
    }
   
    private void Start()
    {
        Debug.Log("TTT gestartet");
        buttons = new string[SpielFeldBreite,SpielFeldBreite];

    }

    private void OnGUI()
    {
        spielrum();
        for (int y = 0; y < SpielFeldBreite; y++)
        {
            for (int x = 0; x < SpielFeldBreite; x++)
            {

                if (GUI.Button(new Rect(40 + x * 50, 40 + y * 50, 40, 40), buttons[x, y]))
                {
                    if (buttons[x, y] == null) { 

                    if (gedrückt == false)
                    {
                        buttons[x, y] = "X";
                    }
                    else
                    {
                        buttons[x, y] = "O";
                    }

                    gedrückt = !gedrückt;

                     print(pruefeLoesung());
                        if (pruefeLoesung())
                        {
                            gameover = true;
                            
                        }
                        break;
                }
                }
            }
        }
    }
}

