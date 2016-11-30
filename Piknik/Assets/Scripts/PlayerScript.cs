using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

    public Text hpText;
    private int hp = 10;
    public static int score = 0;
    public static int highScore = 0;
    public static Text scoreText;
    public Text highText;
    public Text scoreT;

    public GameObject gameover;
    public GameObject spawner1;
    public GameObject spawner2;


    public void Start() {

		score = 0;

        scoreText = GameObject.FindWithTag("Text").GetComponent<Text>();

        SetText(scoreText, score);
        SetText(hpText, hp);
    }

    public void Update() {
        SpawnerActive(spawner1, 10);
        SpawnerActive(spawner2, 30);

    }

    private void DecrementHealth() {
        hp--;
        SetText(hpText, hp);

        if (hp <= 0) {
            if(highScore <= score ) {
                highScore = score;
            }

            SetText(scoreT, score);
            SetText(highText, highScore);

            PauseScript.paused = true;

            gameover.SetActive(true);

        }
    }

    public void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Mosquito")) {
            Handheld.Vibrate();	
            Destroy(other.gameObject);
            DecrementHealth();
        }
    }
    
    private static void SetText(Text txt, object val ) {
        txt.text = val.ToString();
    }

    public static void IncrementScore() {
        score++;
        SetText(scoreText, score);
    }

    public void SpawnerActive(GameObject spawner, int points) {
        if (score >= points) {
            spawner.SetActive(true);

        }

    }	

}