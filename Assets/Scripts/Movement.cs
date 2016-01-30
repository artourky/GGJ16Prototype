using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float xAxis, yAxis, moveSpeed = 5f;

    private Rigidbody _rigidB;

	// Use this for initialization
	void Start () {
        _rigidB = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        xAxis = Input.GetAxis("Horizontal");
        yAxis = Input.GetAxis("Vertical");

        _rigidB.velocity = new Vector3(xAxis * moveSpeed, _rigidB.velocity.y, yAxis * moveSpeed);
	}
}
