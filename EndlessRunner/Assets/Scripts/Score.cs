using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
	public float PlayerPos;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.x.ToString("0");
		PlayerPos = player.position.x;

	}
}
