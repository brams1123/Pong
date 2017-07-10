using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2 : MonoBehaviour {

    public float padSpeed = 1;
    public Vector3 playPos;
	
	// Update is called once per frame
	void Update () {

        float yPos = transform.position.y + (Input.GetAxis("Horizontal") * padSpeed);
        playPos = new Vector3(23, Mathf.Clamp(yPos, -11, 11), 0);
        transform.position = playPos;
    }
}
