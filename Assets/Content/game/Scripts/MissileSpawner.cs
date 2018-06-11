using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileSpawner : MonoBehaviour {

    public GameObject missile;
    public GameObject player;
    // Use this for initialization
    void Start () {
        Vector3 pspawn = new Vector3(2.51f, 0.588f, -2.15f);
        //Instantiate(player, pspawn, Quaternion.identity);
        InvokeRepeating("Spawn", 1.0f, 5.0f);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Spawn()
    {

        
        Vector3 spawn = new Vector3(-9.51f,1.288f,-5.45f);
        Instantiate(missile, spawn, Quaternion.identity);
        


    }
}
