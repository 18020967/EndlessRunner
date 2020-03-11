using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField]
    private float speed = 10.0f;
    [SerializeField]
    private float jumpForce = 15.0f;

    private Vector3 jump;
    private Vector3 forword;
    private Vector3 sideways;
    
    public bool isGrounded = false;

    //private bool moveRight = false;
    //private bool moveLeft = false;

    public int SidewaysCheck = 0;


    private void OnCollisionStay()
    {
        isGrounded = true;
    }


    // Start is called before the first frame update
    void Start()
    {
        jump = new Vector3(0, 2.0f * Time.deltaTime, 0);

        forword = new Vector3(speed * Time.deltaTime, 0, 0);

        sideways = new Vector3(0, 0, 3f);
    }

    // Update is called once per frame

    void Update()
    {
        rb.transform.position += (forword);

        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;

            Debug.Log("Space - Jump");
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);

        }

        if (Input.GetKeyDown(KeyCode.D)&& (SidewaysCheck < 1))
        {
            SidewaysCheck += 1;
            rb.transform.position -= sideways;
            //moveRight = true;    

        }

        if (Input.GetKeyDown(KeyCode.A)&& (SidewaysCheck > -1))
        {
            SidewaysCheck -= 1;
            rb.transform.position +=sideways;
            //moveLeft = true;
        }
    }

    //private void LateUpdate()
    //{
    //    rb.transform.position = new Vector3(rb.transform.position.x,rb.transform.position.y, Mathf.Clamp(rb.transform.position.z, -2, 2));
    //}
    
    //private void FixedUpdate()
    //{
    //    if (moveRight)
    //    {
    //        rb.AddForce(-Vector3.forward * 5, ForceMode.Impulse);
    //        moveRight = false;
    
    //    }

    //    if (moveLeft)
    //    {
    //        rb.AddForce(Vector3.forward * 5, ForceMode.Impulse);
    //        moveLeft = false;
    
    //    }
    //}

}
