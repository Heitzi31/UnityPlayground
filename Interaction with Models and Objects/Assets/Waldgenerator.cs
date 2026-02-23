using UnityEngine;

public class Waldgenerator : MonoBehaviour
{

    public GameObject[] protoFichte;
    public GameObject truckPointer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject kopie = Instantiate(protoFichte[0].gameObject);

            Vector3 spawnPosition = new Vector3(Random.value * 30 - 15, 0, Random.value * 30 - 15);
            kopie.transform.position = spawnPosition;
            float scale = Random.Range(0.1f, 1f);
            kopie.transform.localScale = new Vector3(scale, scale, scale);
            float rotation = Random.Range(-180f, 180f);
           // Debug.Log(rotation);
            kopie.transform.rotation = Quaternion.Euler(0, rotation, 0);

            Fichte fichteScript = kopie.GetComponent<Fichte>();
            fichteScript.transporter = truckPointer;
        }
    }

}
