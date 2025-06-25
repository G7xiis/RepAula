using UnityEngine;

public class RayTeste : MonoBehaviour
{
    public LayerMask enemyLayer;
    public float maxDistance = 100f;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(ray.origin, ray.direction * maxDistance, Color.red, 1f);

            if (Physics.Raycast(ray, out RaycastHit hit, maxDistance, enemyLayer))
            {
                Debug.Log("Acertou inimigo: " + hit.collider.name);
                Destroy(hit.collider.gameObject);
            }
            else
            {
                Debug.Log("Não acertou nenhum inimigo.");
            }
        }
    }
}