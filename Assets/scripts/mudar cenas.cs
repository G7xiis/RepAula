using UnityEngine;
using UnityEngine.SceneManagement;

public class mudarcenas : MonoBehaviour
{
    public string nomecena;


    public void mudarcena()
    {

        SceneManager.LoadScene(nomecena);

    }

    public void sair()
    {
        Application.Quit();
    }

    private void Update()
    {
        DontDestroyOnLoad(gameObject);
    }
}
