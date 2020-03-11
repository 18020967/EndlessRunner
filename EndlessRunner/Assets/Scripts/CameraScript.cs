using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField]
    GameObject FollowPlayer;
    Transform PlayerX;

    private Vector3 sideways;

    public int SidewaysCheck = 0;
    public float xValue = 0;

    Vector3 PlayerPos;
    Vector3 CameraPos;

    private void Start()
    {
        sideways = new Vector3(0, 0, 2f);
    }
    // Update is called once per frame
    void Update()
    {
        PlayerPos = new Vector3(FollowPlayer.transform.position.x-7,4,xValue);
        gameObject.transform.position = PlayerPos;

        if (Input.GetKeyDown(KeyCode.D) && (SidewaysCheck < 1))
        {
            SidewaysCheck += 1;
           // gameObject.transform.position -= (sideways);
            xValue -= 1;
        }

        if (Input.GetKeyDown(KeyCode.A) && (SidewaysCheck > -1))
        {
            SidewaysCheck -= 1;
            //gameObject.transform.position += (sideways);
            xValue += 1;

        }

    }
}
