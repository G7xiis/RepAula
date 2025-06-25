using System.Diagnostics;
using Unity.Android.Types;
using UnityEngine;


public class andar : MonoBehaviour
{
    public float speed;
    public float jumpforce;
    public bool isgrouded;
    public Rigidbody rb;
    private bool isGrouded;
    public float rotationspeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Andar();
        if (Input.GetKey(KeyCode.Space) && isGrouded)
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            isGrouded = false;
        }


        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(new Plane(Vector3.up, transform.position).Raycast(ray,out float distance))
        {

            Vector3 look = ray.GetPoint(distance);
            Vector3 direction = (look - transform.position);
            direction.y = 0;

            if (direction.sqrMagnitude > 0.001f)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotationspeed);
            }


        }
    }


    
    public void Andar()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 movent = new Vector3(moveX, 0, moveY);
        transform.Translate(movent * speed * Time.deltaTime);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("chao"))
        {
            isGrouded = true;
        }
    }
}