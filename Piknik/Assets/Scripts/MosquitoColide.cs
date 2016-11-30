using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MosquitoColide : MonoBehaviour {

	 public Transform target;

	 public float verticalSpeed;

	 public int direction;

	 private Vector3 tempPosition;



	void Start() {
		if (direction == -1) {
		   transform.localScale += new Vector3(-2.0F, 0, 0);

	  	}

	

	}

	void Update() {
		
		for (int i = 0; i < Input.touchCount; i++) {
  	
	  		Touch touch = Input.GetTouch(i);

			Vector3 pos = Camera.main.ScreenToWorldPoint(touch.position);

 			RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

  			if (touch.phase == TouchPhase.Began) {
				  if(hit != null && hit.collider != null && hit.collider.gameObject.CompareTag("Mosquito")) {
				  	PlayerScript.IncrementScore();
					GameObject.FindWithTag("Audio").GetComponent<AudioSource>().Play();
					Destroy(hit.collider.gameObject);
				  }
			}
		  
		  
  		}
  
	}

	void FixedUpdate () {
		verticalSpeed = Random.Range(1.0F, 8.0F);

		float step = verticalSpeed * Time.deltaTime;

		transform.position = Vector3.MoveTowards(transform.position, target.position, step);
	}
}
