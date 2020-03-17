public class MovePosition : MonoBehaviour
{
    public float movespeed = 200.0f;
    public Rigidbody rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

        if (Input.GetButton("Horizontal"))
        {
            transform.localPosition += Input.GetAxis("Horizontal") * transform.right * Time.deltaTime * movespeed;
        }
        {
            if (Input.GetButton("Vertical"))
                transform.localPosition += Input.GetAxis("Vertical") * transform.forward * Time.deltaTime * movespeed;
        }
    }
}
