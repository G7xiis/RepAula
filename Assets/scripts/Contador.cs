using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Contador : MonoBehaviour
{

    public int  moeda = 0;
    public TextMeshProUGUI contador;


    public void adicionarMoedas()
    {
        moeda++;
        contador.text = "Moedas: " + moeda;

    }





}
