using UnityEngine;
using System.Collections;
using MidiJack;

public class MyRotate : MonoBehaviour {
	public int knobNumber = 16;
	[SerializeField]
	private float knobVal; // value of knob
	[SerializeField]
	// private float rotateSpeed = 1.0f; // In rotations per second

	//Rotation Sensitivity
	public float RotationSensitivity = 50.0f;
	public float minAngle = -360.0f;
	public float maxAngle = 360.0f;

	//Rotation Value
	float yRotate = 0.0f;

	// Update is called once per frame
	void Update () {
		knobVal = MidiMaster.GetKnob(knobNumber);
		//Rotate Y view
		yRotate += 	knobVal * RotationSensitivity * Time.deltaTime;
		yRotate = Mathf.Clamp (yRotate, minAngle, maxAngle);
		transform.eulerAngles = new Vector3 (0.0f, yRotate, 0.0f);
	}

}
