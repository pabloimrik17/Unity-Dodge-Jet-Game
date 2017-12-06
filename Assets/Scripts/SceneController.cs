using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

	public void StartGame() {
		SceneManager.LoadScene(0);
	}

	public void LeaderBoard() {
		SceneManager.LoadScene(1);
	}

	public void EndGame() {
		Application.Quit();
	}
}
