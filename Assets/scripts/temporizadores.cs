using UnityEngine;
using System.Collections;
using Unity.Mathematics;

public class tempo : MonoBehaviour
{
    public GameObject prefab;
    public bool podespawnar;
    public float Tempo;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) && podespawnar)
        {
            StartCoroutine(timer(2f));
        }
        
        if  (Input.GetKeyDown(KeyCode.J) && podespawnar)
        {
            podespawnar = false;
            Instantiate(prefab, transform.position, quaternion.identity);
            Invoke("timer2", 2f);
        }

    }

    public IEnumerator timer(float segundos)
    {
        podespawnar = false;
        yield return new WaitForSeconds(segundos);
        Instantiate(prefab, transform.position, quaternion.identity);
        podespawnar = true;

    }

    public void Timer2()
    {
        podespawnar = true;
    }
}
