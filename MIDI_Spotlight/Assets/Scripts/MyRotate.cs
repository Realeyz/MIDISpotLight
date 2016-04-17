using UnityEngine;
using System.Collections;

public class MyRotate : MonoBehaviour {

	[SerializeField]
	private float rotateSpeed = 1.0f; // In rotations per second
	// Use this for initialization
	void Start () {
		StartCoroutine (Spin ());
	}
	
	private IEnumerator Spin()
	{
		while (true) // loop always
		{
			transform.Rotate (transform.up, 360 * rotateSpeed * Time.deltaTime); //transform.up = around Y axis
			yield return 0; // do at end of Update (deprioritize)
		}
	}
}
