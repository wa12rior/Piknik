using UnityEngine;
using System.Collections;

public class HeartsScript : MonoBehaviour {

	public GameObject heart1;
	public GameObject heart2;
	public GameObject heart3;

	public void Update() {

		if(StoryModeSpawn.health == 2) {
			heart1.SetActive(false);

		} else if (StoryModeSpawn.health == 1) {
			heart2.SetActive(false);
			
		} else if (StoryModeSpawn.health == 0) {
			heart3.SetActive(false);

		}

	}
}
