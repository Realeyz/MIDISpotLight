using UnityEngine;
using System.Collections;
using MidiJack;

public class MyRotate : MonoBehaviour {
	public int knobNumber = 16;
	[SerializeField]
	private float knobVal; // value of knob
	[SerializeField]
	private float rotateSpeed = 1.0f; // In rotations per second


	void Awake()
	{
		knobVal = MidiMaster.GetKnob(knobNumber);
		// transform.localScale = new Vector3(1, s, 1);
		transform.Rotate (transform.up, rotateSpeed * knobVal); //transform.up = around Y axis
	}


	void Update()
	{
		// var channels = MidiMaster.GetKnobNumbers();
		knobVal = MidiMaster.GetKnob(knobNumber);
		// transform.localScale = new Vector3(1, s, 1);
		transform.Rotate (transform.up, rotateSpeed * knobVal); //transform.up = around Y axis
	}
}
