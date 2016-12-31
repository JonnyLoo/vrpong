using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    private float xSpeed, ySpeed, zSpeed;
    private Vector3 origPoint;


	void Start () {
        xSpeed = (float) 10;
        ySpeed = (float) 10;
        zSpeed = (float) 10;

        origPoint = transform.position;
	}
	
	void Update () {
        transform.Translate(new Vector3 (xSpeed, ySpeed, zSpeed) * Time.deltaTime);

        if(transform.position.z > 34 || transform.position.z < -30)
        {
            transform.position = origPoint;
        }
	}

    void OnTriggerEnter(Collider other){
        string tag = other.gameObject.tag;
        if (tag.CompareTo("player")  == 0)
        {
            zSpeed *= -1;
        }
        else if(tag.CompareTo("sides") == 0)
        {
            xSpeed *= -1;
        }
        else
        {
            ySpeed *= -1;
        }
    }
}
