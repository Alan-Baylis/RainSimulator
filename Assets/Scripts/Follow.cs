using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    public Transform target;
    float offsetX;
    float offsetZ;

	// Use this for initialization
	void Start () {
        offsetX = target.position.x - transform.position.x;
        offsetZ = target.position.z - transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(offsetX + target.position.x, transform.position.y, offsetZ + target.position.z);
    }
}
