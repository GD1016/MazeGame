﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandWalkerAI : MonoBehaviour {
    public Character Character;
    int framecounter;
    public float _turnTime = 0.5f;
    float turnTime = _

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        turnTime -= Time.deltaTime;

        if (turnTime < 0) {
            turnTime = 0.5f;
            move();
        }

        //Alternative
        //int randomMovementIndex = Random.Range(0, 4);
        //Character.Direction randomDirection = (Character.Direction)randomMovementIndex;


    }

    void move() {
        int random = Random.Range(0, 4);
        if (random == 0) {
            Character.move(Character.Direction.left);
            return;
        }
        if (random == 1) {
            Character.move(Character.Direction.right);
            return;
        }
        if (random == 2) {
            Character.move(Character.Direction.up);
            return;
        }
        if (random == 3) {
            Character.move(Character.Direction.down);
            return;
        }
    }

}

