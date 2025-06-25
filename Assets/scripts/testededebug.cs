using UnityEngine;

public class testedebug : MonoBehaviour
{
    public int vida = 100;
    public GameObject inimigo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("iniciando sistema de debug...");

        inimigo = GameObject.Find("inimigo");

        if (vida < 50)
        {
            Debug.LogWarning("atenção: vida do jogador esta abaixo de 50!");
        }

        if (inimigo == null)
        {
            Debug.LogError("erro: inimigo nao encontrado na cena!");
        }

        else
        {
            Debug.LogError("inimigo encontrado com sucesso!");
        }
    }

   
}
