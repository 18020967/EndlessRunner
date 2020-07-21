using UnityEngine;
using UnityEngine.SceneManagement;

public class _GameManager : MonoBehaviour
{

	bool gameHasEnded = false;
	
	public void EndGame()
	{
		if (gameHasEnded == false)
		{
			gameHasEnded = true;
			//Debug.Log("END GAME");
			FindObjectOfType<PlayerMovement>().MovementEnabled = false;
			EndGameMenu();
		}
		
	}

	public void Restart()
	{
		SceneManager.LoadSceneAsync("Level01");
	}

	public void BeginGame()
	{
		SceneManager.LoadSceneAsync("Level01");
	}

	public void GameMenu()
	{
		SceneManager.LoadSceneAsync("Main menu");
	}

	public void EndGameMenu()
	{
		SceneManager.LoadSceneAsync("EndGame");
	}
}
