public class Velocity : MonoBehaviour
{
    public float forwardForce = 5;
    public Rigidbody rb;

    void Start()
    {
        Debug.Log("Hello World");
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float Vertical = Input.GetAxis("Vertical");
        float Horizontal = Input.GetAxis("Horizontal");

        if (Horizontal > 0)
        {
            transform.Translate(0.05f, 0, 0);
        }
        if (Horizontal < 0)
        {
            transform.Translate(-0.05f, 0, 0);
        }
       
        if (Vertical < 0)
        {
            transform.Translate(0, 0, -.5f);
        }
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
    }
}
