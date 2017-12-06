using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyMissile : MonoBehaviour {

	 public float lifetime;

     private SceneController sceneController;
 
    void Start() {
        Destroy(gameObject, lifetime);
    }
 
    void OnCollisionEnter(Collision other) {
        Destroy(other.gameObject);

        saveResults();
        Destroy(gameObject);

        sceneController = gameObject.AddComponent<SceneController>();
        sceneController.LeaderBoard();
    }

    void saveResults() {
        Leaderboard leader = gameObject.AddComponent<Leaderboard>();
        leader.writeToXML();
    }
}
