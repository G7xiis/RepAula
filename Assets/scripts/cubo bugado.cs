using UnityEngine;

public class cubobugado : MonoBehaviour
{
    public float velocidadeAndar = 5f;
    public float velocidadegirar = 100f;
    public float velocidadeCrescer = 1f;

    [Header("teleporte")]
    public Vector3 pos1;
    public Vector3 pos2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
                                                
    }

    // Update is called once per frame
    void Update()
    {
     
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, -velocidadegirar * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up, -velocidadegirar * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.M))
        {
            transform.localScale += Vector3.one * velocidadeCrescer * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.F))
        {
            transform.localScale -= Vector3.one * velocidadeCrescer * Time.deltaTime;
        }

        if(Input.GetKeyDown(KeyCode.T))
        {
            transform.position = pos1;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            transform.position = pos2;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position -= transform.forward * velocidadeAndar * Time.deltaTime;
        }
    }
}
