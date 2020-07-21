using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    [SerializeField]
    public float speed ;

    private Vector3 jump;
    private Vector3 forword;
    private Vector3 sideways;
    
    public bool isGrounded = false;
	public bool MovementEnabled = true;

    public int SidewaysCheck = 0;


    private void OnCollisionStay()
    {
        isGrounded = true;
    }



    void Start()
    {
        jump = new Vector3(0, 2f, 0);

        forword = new Vector3(speed, 0, 0);

        sideways = new Vector3(0, 0, 3f);
    }

    void Update()
    {
		if (MovementEnabled)
		{
			if (Input.GetKey(KeyCode.Space) && isGrounded)
			{
				isGrounded = false;

				rb.transform.position += jump;

			}

			if (Input.GetKeyDown(KeyCode.D) && (SidewaysCheck < 1))
			{
				SidewaysCheck += 1;
				rb.transform.position -= sideways;
				   
			}

			if (Input.GetKeyDown(KeyCode.A) && (SidewaysCheck > -1))
			{
				SidewaysCheck -= 1;
				rb.transform.position += sideways;
				
			}
		}
    }

	private void FixedUpdate()
	{
		if (rb.position.y < -1)
		{
			FindObjectOfType<_GameManager>().EndGame();

		}
		if (MovementEnabled)
		{
			rb.transform.position += (forword);
		}
	}

}
