using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText ;
	public Text obstaclePassedText;
	int obsText;
	float distance;

	private void Start()
	{
		distance = 0;
		obsText = 0;
		DisplayScore();
	}

	void Update()
    {
		distance = player.transform.position.x;

		DisplayScore();

		obsText = player.gameObject.GetComponent<PlayerCollision>().obstaclePassed;

		DisplayScore();

	}

	void DisplayScore()
	{
		scoreText.text = "Distance : " + distance.ToString("0");
		obstaclePassedText.text = "Obstacles/Coins :" + obsText.ToString();
	}
}
