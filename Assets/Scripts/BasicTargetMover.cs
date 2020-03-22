using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour
{
    public bool doSpin = true;
    public float spinSpeed = 180.0f;

    public bool doMotion = false;
    public float motionMagnitude = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotate around the 'up' axis of the object if 'doSpin'
        if(doSpin)
            gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);

        //move up and down over time if 'doMotion'
        if(doMotion)
            gameObject.transform.Translate(Vector3.up * motionMagnitude * Mathf.Cos(Time.timeSinceLevelLoad));
    }
}
