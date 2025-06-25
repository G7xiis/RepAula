using UnityEngine;
using UnityEngine.AI;
public class InimigoIA : MonoBehaviour
{
    public Transform player;
    public float distanciaMinima = 1.5f;

    private NavMeshAgent agent;
    private bool esperando = false;

    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public void Update()
    {
        float distancia = Vector3.Distance(transform.position, player.position);

        if (distancia > distanciaMinima && !esperando)
        {
            esperando = true;
            agent.SetDestination(player.position);
        }
        else if (distancia <= distanciaMinima && !esperando)
        {
            agent.ResetPath(); //Para de andar
            esperando = true;
            Invoke("Delay", 5f);
        }
    }
    public void Delay()
    {
        esperando = false;
    }
}