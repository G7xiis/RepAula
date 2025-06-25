using UnityEngine;

public class spaw : MonoBehaviour
{
    public GameObject objetoprefab;

    // Update is called once per frame
    void Update()
    {
         
        {
            Vector3 pos = new Vector3(Random.Range(10.209f, -20.46f),1, Random.Range(7.679f, -20.46f));
            GameObject obj = Instantiate(objetoprefab, pos, Quaternion.identity);
            Destroy(obj, 3f);


        }
    }
}
