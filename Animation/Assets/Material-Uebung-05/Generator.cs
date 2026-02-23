using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject Ebene;
    public GameObject[] protoPflanze;
    public MeshRenderer meshrenderer;
    private void Start()
    {
        meshrenderer = Ebene.GetComponent<MeshRenderer>();

        for (int i = 0; i < 300; i++)
        {
            GameObject kopie = Instantiate(protoPflanze[0].gameObject);

            Vector3 spawnPosition = new Vector3(Random.value * meshrenderer.bounds.size.x - (meshrenderer.bounds.size.x/2), 0, Random.value * meshrenderer.bounds.size.z-(meshrenderer.bounds.size.z/2));
            kopie.transform.position = spawnPosition;

        }
    }
}
