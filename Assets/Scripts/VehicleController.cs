using UnityEngine;

public class VehicleController : MonoBehaviour
{
    private float turnSpeed = 30.0f;
    private float horizontalInput;
    private float forwardInput;

    protected Rigidbody rb; //Encapsulation

    private float speed = 10f; 
    public float Speed //Encapsulation
    {
        get { return speed; }
        protected set { speed = Mathf.Clamp(value, 0, 100); }
    }

    [SerializeField] private AudioClip honkSound; //Abstraction
    private AudioSource audioSource; //Abstraction

    protected virtual void Start() //Encapsulation and Abstraction
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();

    }

    public virtual void Move() //Abstraction
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
      
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
    public virtual void Honk() //Abstraction
    {
        audioSource.PlayOneShot(honkSound);
    }
}
