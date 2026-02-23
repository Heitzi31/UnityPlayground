using UnityEngine;

public class Transporter : MonoBehaviour
{

    public GameObject[] stammArray;
    int stammLimit = 5;
    public int currentStammNumber = 0;


    public void Beladen()
    {
        if (currentStammNumber < stammLimit)
        {
            switch (currentStammNumber)
            {
                case 0:
                    stammArray[0].SetActive(true);
                    Debug.Log("Jetzt Beladen!");
                    break;
                case 1:
                    stammArray[1].SetActive(true);
                    Debug.Log("Jetzt Beladen!");
                    break;
                case 2:
                    stammArray[2].SetActive(true);
                    Debug.Log("Jetzt Beladen!");
                    break;
                case 3:
                    stammArray[3].SetActive(true);
                    Debug.Log("Jetzt Beladen!");
                    break;
                case 4:
                    stammArray[4].SetActive(true);
                    Debug.Log("Truck ist voll beladen!");
                    break;
                default:
                    Debug.Log("Beladen fehlgeschlagen :( ");
                    break;
            }
        }

        currentStammNumber++;
    }

    private void OnGUI()
    {
        if (currentStammNumber == 5)
        {
            GUIStyle alterStil = new GUIStyle(GUI.skin.label); // Kopie des Stils vor Änderung
                                                               // Textstil ändern und gelben Text zeichnen:
            GUI.skin.label.fontSize = 75;
            GUI.skin.label.fontStyle = FontStyle.Bold;
            GUI.skin.label.alignment = TextAnchor.MiddleCenter;
            GUI.color = Color.black; // Schatten-Effekt
            GUI.Label(new Rect(2, 2, Screen.width, Screen.height), "Der Truck ist voll beladen!");
            GUI.color = Color.yellow; //gelber Text
            GUI.Label(new Rect(0, 0, Screen.width, Screen.height), "Der Truck ist voll beladen!");
            GUI.skin.label = alterStil; // Textstil vor Änderungen wiederherstellen.
        }
    }

}
