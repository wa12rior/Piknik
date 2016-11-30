using UnityEngine;
using System.Collections;

public class SpawningMenu : MonoBehaviour {

	public float delay;
	public GameObject target;
	public int DistanceX;
	
	void Start () {

		InvokeRepeating("SpawnObject",delay,delay);

	}
	
	void SpawnObject() {
      
       // float z = Random.Range(-2.0f, 2.0f);
        Instantiate(target, new Vector3(DistanceX, 0, 200), Quaternion.identity);
    }

	void Update () {
	
	}
}
