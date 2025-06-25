using UnityEngine;

public class GerenciadorDeJogo : MonoBehaviour
{
    public int vidas = 3;
    public int pontuacao = 0;
    GameObject jogador;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jogador = GameObject.Find("Jogador");
        if (jogador = null)
        {
            Debug.Log("Jogador não encontrado");
        }
        else
        {
            Debug.Log("Jogo iniciado com " + vidas + " vidas.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReiniciarJogo();
        }
    }

    void ReiniciarJogo()
    {
        vidas = 3;
        pontuacao = 0;
        Debug.Log("Jogo reiniciado");
    }
}
