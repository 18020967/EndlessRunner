using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Platforms;
    float PlatLength = 9;

    void Start()
    {
        for (int i = 1; i < 40; i++)
        {
            PlacePlatform();
        } 
    }


    int randomNum;
    public void PlacePlatform()
    {
        randomNum = Random.Range(0,Platforms.Length);
        //Debug.Log(randomNum);
        Instantiate(Platforms[randomNum], new Vector3(PlatLength, 0, 0),Quaternion.identity);
        PlatLength += 18;
    }
}
