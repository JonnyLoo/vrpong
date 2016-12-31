using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour {

    public float speed;
    private Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update() {

    }

    //Before any physics code
    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal2");
        float moveVertical = Input.GetAxis("Vertical2");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
        rb.MovePosition(transform.position + movement);
    }

    void OnCollisonEnter(Collision collision) {
        if (collision.gameObject.name == "Ceiling" || collision.gameObject.name == "East Wall" || collision.gameObject.name == "West Wall" || collision.gameObject.name == "Floor") {
            rb.velocity = Vector3.zero;
        }
    }
}