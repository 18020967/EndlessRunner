using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	[SerializeField]
	public int obstaclePassed = 0;
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Obstacle")
		{
			//Debug.Log("END GAME");
			FindObjectOfType<_GameManager>().EndGame();

		}

	}
	public void ObstaclePassedInc()
	{
		obstaclePassed++;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "PassedObstacle")
		{
			//Debug.Log("IT WORKS!");
			ObstaclePassedInc();
			Destroy(other.gameObject);
		}
	}
}
