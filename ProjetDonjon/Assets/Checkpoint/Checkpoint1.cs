﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider player)
    {
        if (player.tag == "Player") ;
        {
            player.GetComponent<Player>().CheckPos = transform.position;
        }
    }
}
