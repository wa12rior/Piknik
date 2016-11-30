using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {

	public GameObject SettingsMenu;
	public GameObject Settings;

	public static bool paused;

	// Use this for initialization
	void Start () {
		paused = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (paused) {
			Time.timeScale = 0;

		} else if (!paused) {
			Time.timeScale = 1;

		}

	
	}

	public void PauseFunc() {
		paused = !paused;

	}

	public void SettingsShow() {
		Settings.SetActive(false);
		SettingsMenu.SetActive(true);
		PauseFunc();
	}

	public void SettinsHide() {
		Settings.SetActive(true);
		SettingsMenu.SetActive(false);
		PauseFunc();

	}
}
