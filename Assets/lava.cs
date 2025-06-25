using UnityEngine;

public class lava : MonoBehaviour
{
    public GameObject boneco;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BONECO"))
        {
       
            Destroy(boneco);
        }
    }
}
