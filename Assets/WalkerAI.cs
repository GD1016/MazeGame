﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkerAI : MonoBehaviour {

    public Character character;

    float timer = 0.5f; // timer variable, used as a "countdown" to next move

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    public void Update() {
        print("WalkerAI Update");
        

        timer -= Time.deltaTime; // subtract time since last frame
        if (timer > 0f) { // if countdown not done, skip
            return;
        }
        timer = 0.5f; // if we get here, reset timer
        Move(); // and move
    }

    protected virtual void Move() {
        print("Empty Move");
    }
}