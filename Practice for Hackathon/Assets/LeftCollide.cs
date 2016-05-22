using UnityEngine;
using System.Collections;

public class LeftCollide : MonoBehaviour {
	public GameObject car;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onCollisionEnter(Collision other) {
		if (other.gameObject.CompareTag ("LeftControl")||other.gameObject.CompareTag ("RightControl")) {
			car.transform.Rotate(Vector3.up * -20f * Time.deltaTime);
		}
	}
}
