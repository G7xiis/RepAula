using UnityEngine;

public class loop : MonoBehaviour
{
    [Header("objeto a ser gerado")]
    public GameObject prefab;
   
    void Start()
    {
      for (int i = 0; i < 2; i++)
        {
            GameObject obj = Instantiate(prefab, new Vector3(Random.Range(-3.763f, 3.13f), 2, Random.Range(6.54f, 3.13f)), Quaternion.identity);

        }

      int pontos =0;

      while (pontos < 100)
        {
            Debug.Log("ganhou ponto");
            pontos++;

            Debug.Log("pontuaçao maxima");

        }


    }
}
