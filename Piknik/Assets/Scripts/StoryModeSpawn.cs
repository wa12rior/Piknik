using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StoryModeSpawn : MonoBehaviour {

	public GameObject mosquitoPrefab;
	public GameObject winMonit;
	public GameObject loseMonit;
	public GameObject ST;

	public Text scoreText;
	public Text monitScore;
	public Text starsMonit;
	
	public static int score;
	public static int health;

	public int stars;
	public int neededPoints;

	public float delay;
	public float DistanceX, DistanceY, mn;

	void Start () {
		score = 0;
		health = 3;

		InvokeRepeating("Generate", 1, delay);

	}
	
	void Update () {
		scoreText.text = score.ToString();

		if (health == 0) {
			OnLostLevel();
		}

		if (score >= neededPoints) {
			
			OnEndOfLevel();

		}

		DistanceY = mn + Random.Range(-5.0F, 5.0F);
		

	}

	void Generate() {

		Instantiate(mosquitoPrefab, new Vector3(DistanceX, DistanceY, 0), Quaternion.identity);

	}

	public void StarsOperation() {
		stars = health;

		starsMonit.text = stars.ToString();
	}

	public void OnLostLevel() {
			monitScore.text = score.ToString();
			loseMonit.SetActive(true);
			ST.SetActive(true);
			PauseScript.paused = true;
	}

	public void OnEndOfLevel() {
		StarsOperation();
		monitScore.text = score.ToString();

		ST.SetActive(true);
		winMonit.SetActive(true);
		PauseScript.paused = true;

	}
}
