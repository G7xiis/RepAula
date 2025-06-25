using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform alvo;
    public Vector3 offset = new Vector3(0, 7, -10);

    public float dureçaotremor;
    public float intensiadadetremor;

    private float tempotremor;
    private Vector3 offSettremor;
    public float suavizaçao;

    public void LateUpdate()
    {

        if (tempotremor > 0)
        {
            offSettremor = Random.insideUnitSphere * intensiadadetremor;

            tempotremor -= Time.deltaTime;

        }
        else
        {
            offSettremor = Vector3.zero;

            Vector3 posiçaoDesejada = transform.position = alvo.position + offset + offSettremor;
            transform.position = Vector3.Lerp(transform.position, posiçaoDesejada, suavizaçao * Time.deltaTime);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Tremor(); // Chama o tremor!

        }
    }
    public void Tremor()
    {
        tempotremor = dureçaotremor;

    }
}
