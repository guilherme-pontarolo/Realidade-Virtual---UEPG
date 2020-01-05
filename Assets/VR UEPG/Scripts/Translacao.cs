using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translacao : MonoBehaviour {

    public float VelRot;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, VelRot * Time.deltaTime, 0);
	}
}
