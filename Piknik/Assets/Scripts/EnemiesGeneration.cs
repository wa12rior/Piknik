using UnityEngine;
using System.Collections;

public class EnemiesGeneration : MonoBehaviour {

	public float delay;
	public GameObject target;
	public float DistanceX, DistanceY;

	private float height;

	void Generate() {
		delay = Random.Range(1.0F, 3.0F);
		height = DistanceY +  Random.Range(-2.0F, 2.0F);

		Instantiate(target, new Vector3(DistanceX, height, 0), Quaternion.identity);

	}

	void Start () {
		InvokeRepeating("Generate", 1, delay);
		
	}
	
	void Update () {
		
	}
}
