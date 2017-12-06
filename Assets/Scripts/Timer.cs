using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text scoreText;

	private int minutes;
	private int seconds;
	
	private float Score;
	
	// Update is called once per frame
	void Update () {
		Score += Time.deltaTime;
		minutes = Mathf.FloorToInt(Score / 60f);
		seconds = Mathf.FloorToInt(Score - minutes * 60f);
		
		string formatedTime = string.Format(" {0:0}:{1:00}", minutes, seconds);
		scoreText.text = "Survival Time: " + System.Environment.NewLine + formatedTime;
	}
}
