using UnityEngine;
using System.Collections;

public class TargetMover : MonoBehaviour {

	// define the possible states through an enumeration
	public enum motionDirections {Spin, Horizontal, Vertical, Circle, Diagonal };
	
	// store the state
	public motionDirections motionState = motionDirections.Horizontal;

	// motion parameters
	public float spinSpeed = 180.0f;
	public float motionMagnitude = 0.1f;

	// Update is called once per frame
	void Update () {

		// do the appropriate motion based on the motionState
		switch(motionState) {
			case motionDirections.Spin:
				// rotate around the up axix of the gameObject
				gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
				break;
			
			case motionDirections.Vertical:
				// move up and down over time
				gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
				break;

            case motionDirections.Horizontal:
                // move left and right over time
                gameObject.transform.Translate(Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
                break;

			case motionDirections.Circle:
				// move up/down right/left over time in a circular pattern
				gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
				gameObject.transform.Translate(Vector3.right * Mathf.Sin(Time.timeSinceLevelLoad) * motionMagnitude);
				break;

			case motionDirections.Diagonal:
				// move up/down right/left over time in a circular pattern
				gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
				gameObject.transform.Translate(Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
				break;

		}
	}
}
