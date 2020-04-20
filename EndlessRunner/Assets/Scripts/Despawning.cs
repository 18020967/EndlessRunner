
using UnityEngine;

public class Despawning : MonoBehaviour
{
	private float Playerpos;
	private void Start()
	{
		GameObject thePlayer = GameObject.Find("Player");
		Score score = thePlayer.GetComponent<Score>();
		Playerpos = score.PlayerPos;
	}


	private void Update()
	{
		
		if (gameObject.transform.position.x <= Playerpos - 20)
		{
			Destroy(gameObject);
			Debug.Log("platform destroyed"+ gameObject.transform.position.x +"  :"+Playerpos);
		}
	}




}
