using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider collider)
    {
        print("Entered");
        collider.gameObject.SetActive(false);
    }

    void OnTriggerExit(Collider collider)
    {
        print("Exitted");
    }
}
