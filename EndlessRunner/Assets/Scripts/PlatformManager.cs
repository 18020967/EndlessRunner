using UnityEngine;

public class PlatformManager : MonoBehaviour
{
	public Transform player;
	int obstacles;
	bool boss = false;

	[SerializeField]
    private GameObject[] Platforms;

	[SerializeField]
	private GameObject[] BossPlatforms;

	float PlatLength = 9;

    void Start()
    {
        for (int i = 1; i < 10; i++)
        {
            PlacePlatform();
        } 
    }


    int randomNum;
	int bossRanNum;
	public void PlacePlatform()
	{
		if (boss == false)
		{ 
			randomNum = Random.Range(0, Platforms.Length);
			Instantiate(Platforms[randomNum], new Vector3(PlatLength, 0, 0), Quaternion.identity);
			PlatLength += 18;
		}
		else
		{
			bossRanNum = Random.Range(0, BossPlatforms.Length);
			Instantiate(BossPlatforms[bossRanNum], new Vector3(PlatLength, 0, 0), Quaternion.identity);
			PlatLength += 18;
		}
    }

	private void Update()
	{
		obstacles = player.gameObject.GetComponent<PlayerCollision>().obstaclePassed;

		if (obstacles >= 10)
		{
			boss = true;
		}
	}
}
