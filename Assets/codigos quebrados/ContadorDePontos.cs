using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public int pontos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pontos = 0;
        Debug.Log("Jogo Iniciado");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pontos = pontos + 1;
            Debug.Log("Pontos atuais): " + pontos);
        }
    }
}
