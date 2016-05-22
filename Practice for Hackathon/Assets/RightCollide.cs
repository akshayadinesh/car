using UnityEngine;
using System.Collections;

public class RightCollide : MonoBehaviour {
	
	public GameObject car1;

	// Use this for initialization
	void Start () {
		car1 = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onCollisionEnter(Collision other) {
		if (other.gameObject.CompareTag ("LeftControl")||other.gameObject.CompareTag ("RightControl")) {
			car1.transform.Rotate(Vector3.up * 20f * Time.deltaTime);
		}
	}
}
