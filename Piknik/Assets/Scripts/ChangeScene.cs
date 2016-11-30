using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour {

/**
 * [...]
 * Thanks for all people who 
 * motivated me to write this
 * perfect mobile game. I really 
 * appreciate that.
 *
 * @author  Kamil Serafin
 * @version 1.0, 26/11/16
 *
 */

	public GameObject target;
	public GameObject help;
	public GameObject button;
	public GameObject opt;

	public AudioSource audio;

	public Slider slider;

	void Start() {
		target.SetActive(false);
		help.SetActive(false);
		button.SetActive(false);
		slider.value = audio.volume;

	}

	public void ReturnFromGameModes() {
		target.SetActive(false);

	}

	public void ButtonStartDown() {
	
		target.SetActive(true);
		
	}

	public void ButtonOptionsDown() {


	}

	public void ButtonHelpDown() {
		target.SetActive(false);
		help.SetActive(true);
		button.SetActive(true);
	}

	public void CloseHelp() {

		help.SetActive(false);
		button.SetActive(false);
	}

	public void ChangeToScene(string SceneName) {
		SceneManager.LoadScene(SceneName);

	}

	public void TurnONOptionsWindow() {
		opt.SetActive(true);

	}

	public void TurnOFFOptionsWindow() {
		opt.SetActive(false);

	}

	public void Toggle_Change(bool Value) {
		audio.mute = Value;
	}
	
	public void Volume() {
		audio.volume = slider.value;

	}
}
