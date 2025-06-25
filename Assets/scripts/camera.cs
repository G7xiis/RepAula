using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform alvo;
    public Vector3 offset = new Vector3(0, 7, -10);

    public float dure�aotremor;
    public float intensiadadetremor;

    private float tempotremor;
    private Vector3 offSettremor;
    public float suaviza�ao;

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

            Vector3 posi�aoDesejada = transform.position = alvo.position + offset + offSettremor;
            transform.position = Vector3.Lerp(transform.position, posi�aoDesejada, suaviza�ao * Time.deltaTime);
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
        tempotremor = dure�aotremor;

    }
}
