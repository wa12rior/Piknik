using System;
using UnityEngine;
using System.Collections;

public class LoadingGame : MonoBehaviour {

 public float horizontalSpeed;        //Prędkość w poziomie
 public float verticalSpeed;		  //Prędkość w pionie
 public float amplitude;              //Amplituda czyli max y 
 public int direction;				  //Kierunek lotu i moduł z toru lotu sinusoidy

 private Vector3 tempPosition;

 void Start () {
  	tempPosition = transform.position;
	  if (direction == -1) {
		   transform.localScale += new Vector3(-1.8F, 0, 0);

	  }

	  Destroy (gameObject, 4f);
	  
 }
 
 void FixedUpdate () {
  	tempPosition.x += horizontalSpeed * direction;

	  if (direction == -1) {
		  tempPosition.y = Math.Abs(Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed)* amplitude);
	  
	  } else if (direction == 1) {
		  tempPosition.y = Mathf.Sin(Time.realtimeSinceStartup* verticalSpeed)* amplitude;
	  }
  	
  	transform.position = tempPosition;

 }
}