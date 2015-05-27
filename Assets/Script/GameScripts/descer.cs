using UnityEngine;
using System.Collections;

public class descer : MonoBehaviour {

    private int D;
	// Use this for initialization
	void Start () {

        D = 4;

	}
	
	// Update is called once per frame
	void Update () {

        transform.position -= new Vector3(0, D*Time.deltaTime, 0);

	}
}
