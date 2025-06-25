using UnityEngine;

public class MOEDA : MonoBehaviour
{
    public float rotationSpeed;
    private Contador contador;

    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BONECO"))
        {
            contador.adicionarMoedas();
            Destroy(gameObject);
        }

    }

    public void Awake()
    {
        contador = FindFirstObjectByType<Contador>();
    }
}
