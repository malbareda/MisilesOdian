using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallpop : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnCollisionEnter(Collision collision)
    {
        print("popw");
    }
}
