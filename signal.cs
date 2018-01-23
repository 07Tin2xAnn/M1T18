using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class signal : MonoBehaviour {

    GameObject rocket;
    GameObject pad;
    // Use this for initialization
    void Start () {
        rocket = GameObject.Find("Rocket");
        pad = GameObject.Find("Target Pad");

    }
	
	// Update is called once per frame
	void Update () {
        Transform();
	}
    public void Transform() {
        float dist = Vector3.Distance(rocket.transform.position, pad.transform.position);
        print(dist);
        if (dist < 10f) {
            pad.gameObject.GetComponent<Renderer>().material.color = Color.blue;

        }
    }
}
