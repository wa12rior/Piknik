using UnityEngine;
using System.Collections;

public class StoryMosquitos : MonoBehaviour {

	public float verticalSpeed;

	public Transform target;

	public int pointValue;

	void Start () {
	verticalSpeed = Random.Range(6.0F, 9.0F);

	}
	
	void Update () {
	
	for (int i = 0; i < Input.touchCount; i++) {
  	
	  		Touch touch = Input.GetTouch(i);

			Vector3 pos = Camera.main.ScreenToWorldPoint(touch.position);

 			RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

  			if (touch.phase == TouchPhase.Began) {
				  if(hit != null && hit.collider != null && hit.collider.gameObject.CompareTag("Mosquito")) {
				  	StoryModeSpawn.score += pointValue;
					GameObject.FindWithTag("Audio").GetComponent<AudioSource>().Play();
					Destroy(hit.collider.gameObject);
				  }
			}
		  
		  
  		}
	}

	void FixedUpdate() {


		float step = verticalSpeed * Time.deltaTime;

		transform.position = Vector3.MoveTowards(transform.position, target.position, step);

		if(transform.position == target.position) {
			StoryModeSpawn.health--;
			Handheld.Vibrate();			
			Destroy(gameObject);

		}

	}
}
